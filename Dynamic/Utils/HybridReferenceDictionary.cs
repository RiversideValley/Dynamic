﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Riverside.Scripting.Utils {
    /// <summary>
    /// A hybrid dictionary which compares based upon object identity.
    /// </summary>
    class HybridReferenceDictionary<TKey, TValue> where TKey : class {
        private KeyValuePair<TKey, TValue>[] _keysAndValues;
        private Dictionary<TKey, TValue> _dict;
        private int _count;
        private const int _arraySize = 10;

        public HybridReferenceDictionary() {
        }

        public HybridReferenceDictionary(int initialCapicity) {
            if (initialCapicity > _arraySize) {
                _dict = new Dictionary<TKey, TValue>(initialCapicity);
            } else {
                _keysAndValues = new KeyValuePair<TKey, TValue>[initialCapicity];
            }
        }

        public bool TryGetValue(TKey key, out TValue value) {
            Debug.Assert(key != null);

            if (_dict != null) {
                return _dict.TryGetValue(key, out value);
            }

            if (_keysAndValues != null) {
                for (int i = 0; i < _keysAndValues.Length; i++) {
                    if (_keysAndValues[i].Key == key) {
                        value = _keysAndValues[i].Value;
                        return true;
                    }
                }
            }

            value = default(TValue);
            return false;
        }

        public bool Remove(TKey key) {
            Debug.Assert(key != null);

            if (_dict != null) {
                return _dict.Remove(key);
            }

            if (_keysAndValues != null) {
                for (int i = 0; i < _keysAndValues.Length; i++) {
                    if (_keysAndValues[i].Key == key) {
                        _keysAndValues[i] = new KeyValuePair<TKey, TValue>();
                        _count--;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool ContainsKey(TKey key) {
            Debug.Assert(key != null);

            if (_dict != null) {
                return _dict.ContainsKey(key);
            }

            if (_keysAndValues != null) {
                for (int i = 0; i < _keysAndValues.Length; i++) {
                    if (_keysAndValues[i].Key == key) {
                        return true;
                    }
                }
            }

            return false;
        }

        public int Count {
            get {
                if (_dict != null) {
                    return _dict.Count;
                }
                return _count;
            }

        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() {
            if (_dict != null) {
                return _dict.GetEnumerator();
            }

            return GetEnumeratorWorker();
        }

        private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() {
            if (_keysAndValues != null) {
                for (int i = 0; i < _keysAndValues.Length; i++) {
                    if (_keysAndValues[i].Key != null) {
                        yield return _keysAndValues[i];
                    }
                }
            }
        }

        public TValue this[TKey key] {
            get {
                Debug.Assert(key != null);

                if (TryGetValue(key, out TValue res)) {
                    return res;
                }

                throw new KeyNotFoundException();
            }
            set {
                Debug.Assert(key != null);

                if (_dict != null) {
                    _dict[key] = value;
                } else {
                    int index;
                    if (_keysAndValues != null) {
                        index = -1;
                        for (int i = 0; i < _keysAndValues.Length; i++) {
                            if (_keysAndValues[i].Key == key) {
                                _keysAndValues[i] = new KeyValuePair<TKey, TValue>(key, value);
                                return;
                            }

                            if (_keysAndValues[i].Key == null) {
                                index = i;
                            }
                        }
                    } else {
                        _keysAndValues = new KeyValuePair<TKey, TValue>[_arraySize];
                        index = 0;
                    }

                    if (index != -1) {
                        _count++;
                        _keysAndValues[index] = new KeyValuePair<TKey, TValue>(key, value);
                    } else {
                        _dict = new Dictionary<TKey, TValue>();
                        for (int i = 0; i < _keysAndValues.Length; i++) {
                            _dict[_keysAndValues[i].Key] = _keysAndValues[i].Value;
                        }
                        _keysAndValues = null;

                        _dict[key] = value;
                    }
                }
            }
        }
    }
}
