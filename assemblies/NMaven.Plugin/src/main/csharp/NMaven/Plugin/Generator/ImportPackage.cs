#region Apache License, Version 2.0 
//
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
//
#endregion
using System;
using System.Collections.Generic;

namespace NMaven.Plugin.Generator
{
	/// <summary>
	/// Description of ImportPackage.
	/// </summary>
	[Serializable]
	public class ImportPackage
	{
		private List<String> packages = new List<String>();
		
		public ImportPackage()
		{
		}
				
		public ImportPackage AddPackage(String line)
		{
			packages.Add(line);
			return this;
		}
		
		public List<String> Packages
		{
			get 
			{
				return packages;
			}
		}					
	}
}