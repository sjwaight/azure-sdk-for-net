// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// The parameters that are used by the service to provision a server.  The
    /// parameters marked optional are not required by the service.
    /// </summary>
    public partial class ServerCreateParameters
    {
        private string _administratorPassword;
        
        /// <summary>
        /// Required. Gets or sets the administrator password for the new
        /// server.
        /// </summary>
        public string AdministratorPassword
        {
            get { return this._administratorPassword; }
            set { this._administratorPassword = value; }
        }
        
        private string _administratorUserName;
        
        /// <summary>
        /// Required. Gets or sets the administrator username that will be used
        /// for the new server.
        /// </summary>
        public string AdministratorUserName
        {
            get { return this._administratorUserName; }
            set { this._administratorUserName = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Required. Gets or sets the region in which this server will be
        /// created.  See http://azure.microsoft.com/en-us/regions/#services
        /// for a list of all the available regions.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _version;
        
        /// <summary>
        /// Optional. Gets or sets the version of server to create.  Valid
        /// values are: 1.0, 2.0.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServerCreateParameters class.
        /// </summary>
        public ServerCreateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ServerCreateParameters class with
        /// required arguments.
        /// </summary>
        public ServerCreateParameters(string administratorUserName, string administratorPassword, string location)
            : this()
        {
            if (administratorUserName == null)
            {
                throw new ArgumentNullException("administratorUserName");
            }
            if (administratorPassword == null)
            {
                throw new ArgumentNullException("administratorPassword");
            }
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.AdministratorUserName = administratorUserName;
            this.AdministratorPassword = administratorPassword;
            this.Location = location;
        }
    }
}
