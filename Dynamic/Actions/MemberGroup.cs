// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Reflection;

using Riverside.Scripting.Utils;

namespace Riverside.Scripting.Actions {
    /// <summary>
    /// MemberGroups are a collection of MemberTrackers which are commonly produced
    /// on-demand to talk about the available members.  They can consist of a mix of
    /// different member types or multiple membes of the same type.
    ///
    /// The most common source of MemberGroups is from ActionBinder.GetMember.  From here
    /// the DLR will perform binding to the MemberTrackers frequently producing the value
    /// resulted from the user.  If the result of the action produces a member it's self
    /// the ActionBinder can provide the value exposed to the user via ReturnMemberTracker.
    ///
    /// ActionBinder provides default functionality for both getting members from a type
    /// as well as exposing the members to the user.  Getting members from the type maps
    /// closely to reflection and exposing them to the user exposes the MemberTrackers
    /// directly.
    /// </summary>
    public class MemberGroup : IEnumerable<MemberTracker> {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly MemberGroup EmptyGroup = new MemberGroup(MemberTracker.EmptyTrackers);

        private readonly MemberTracker[] _members;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "noChecks")]
        private MemberGroup(MemberTracker[] members, bool noChecks) {
            Assert.NotNullItems(members);
            _members = members;
        }

        public MemberGroup(params MemberTracker[] members) {
            ContractUtils.RequiresNotNullItems(members, nameof(members));
            _members = members;
        }

        public MemberGroup(params MemberInfo[] members) {
            ContractUtils.RequiresNotNullItems(members, nameof(members));

            MemberTracker[] trackers = new MemberTracker[members.Length];
            for (int i = 0; i < trackers.Length; i++) {
                trackers[i] = MemberTracker.FromMemberInfo(members[i]);
            }

            _members = trackers;
        }

        internal static MemberGroup CreateInternal(MemberTracker[] members) {
            Assert.NotNullItems(members);
            return new MemberGroup(members, true);
        }

        public int Count => _members.Length;

        public MemberTracker this[int index] => _members[index];

        #region IEnumerable<MemberTracker> Members

        public IEnumerator<MemberTracker> GetEnumerator() {
            foreach (MemberTracker tracker in _members) yield return tracker;
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            foreach (MemberTracker tracker in _members) yield return tracker;
        }

        #endregion
    }
}
