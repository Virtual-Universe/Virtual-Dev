/*
 * Copyright (c) Contributors, http://virtual-planets.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 * For an explanation of the license of each contributor and the content it 
 * covers please see the Licenses directory.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the Virtual Universe Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections.Generic;
using Universe.Framework.Services;
using OpenMetaverse;
using OpenMetaverse.Messages.Linden;

namespace Universe.Framework.DatabaseInterfaces
{
    public interface IUserStatsDataConnector : IUniverseDataPlugin
    {
        /// <summary>
        ///     Add/Update a user's stats in the database
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="agentID"></param>
        /// <param name="regionID"></param>
        void UpdateUserStats(ViewerStatsMessage uid, UUID agentID, UUID regionID);

        /// <summary>
        ///     Get the count of sessions that match the given information
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="whereCheck"></param>
        /// <returns></returns>
        int GetCount(string columnName, KeyValuePair<string, object> whereCheck);

        /// <summary>
        ///     Get the information in the given column
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        List<string> Get(string columnName);

        /// <summary>
        ///     Get a certain session from the database
        /// </summary>
        /// <param name="sessionID"></param>
        /// <returns></returns>
        ViewerStatsMessage GetBySession(UUID sessionID);

        /// <summary>
        ///     Remove all sessions from the database
        /// </summary>
        void RemoveAllSessions();

        /// <summary>
        /// connecting Viewer usage count.
        /// </summary>
        /// <returns>The count of each type of viewer.</returns>
        Dictionary<string,int> ViewerUsage ();
    }
}