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

using System.IO;

namespace Universe.Framework.Utilities
{
    public class VersionInfo
    {
        #region Flavour enum

        public enum Flavour
        {
            Development,
            Prerelease,
            RC1,
            RC2,
            Release,
            Post_Fixes
        }

        #endregion

        public const string VERSION_NUMBER = "1.0.3";
        public const Flavour VERSION_FLAVOUR = Flavour.Development;
        public const string VERSION_NAME = "Universe";
        public const string CODE_NAME = "Earth";
        public const string CODE_REL = "Server Name: " + VERSION_NAME +", Code Name: " + CODE_NAME + ", Release: ";

        public static string Version
        {
            get { return GetVersionString(CODE_REL, /*CODE_NAME,*/ VERSION_FLAVOUR); }
        }

        public static string GitVersion
        {
            get { return GetGitVersionString(); }
        }

        static string GetVersionString(string versionNumber, Flavour flavour)
        {
            string versionString = CODE_REL + " " + flavour;
            return versionString;
        }

        static string GetGitVersionString()
        {
            string versionString = "Unknown";

            // Check if there's a custom .version file with the commit hash in it
            // Else return the standard versionString.

            string gitCommitFileName = ".version";

            if (File.Exists(gitCommitFileName))
            {
                StreamReader CommitFile = File.OpenText(gitCommitFileName);
                versionString = CommitFile.ReadLine();
                CommitFile.Close();
            }

            return versionString;
        }
    }
}
