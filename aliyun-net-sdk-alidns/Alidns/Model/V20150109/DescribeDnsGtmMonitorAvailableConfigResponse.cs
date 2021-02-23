/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsGtmMonitorAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode> ipv4IspCityNodes;

		private List<DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode> ipv6IspCityNodes;

		private List<DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode> domainIpv4IspCityNodes;

		private List<DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode> domainIpv6IspCityNodes;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode> Ipv4IspCityNodes
		{
			get
			{
				return ipv4IspCityNodes;
			}
			set	
			{
				ipv4IspCityNodes = value;
			}
		}

		public List<DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode> Ipv6IspCityNodes
		{
			get
			{
				return ipv6IspCityNodes;
			}
			set	
			{
				ipv6IspCityNodes = value;
			}
		}

		public List<DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode> DomainIpv4IspCityNodes
		{
			get
			{
				return domainIpv4IspCityNodes;
			}
			set	
			{
				domainIpv4IspCityNodes = value;
			}
		}

		public List<DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode> DomainIpv6IspCityNodes
		{
			get
			{
				return domainIpv6IspCityNodes;
			}
			set	
			{
				domainIpv6IspCityNodes = value;
			}
		}

		public class DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode
		{

			private string ispName;

			private string ispCode;

			private string cityName;

			private string cityCode;

			private bool? defaultSelected;

			private string groupType;

			private string groupName;

			public string IspName
			{
				get
				{
					return ispName;
				}
				set	
				{
					ispName = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public bool? DefaultSelected
			{
				get
				{
					return defaultSelected;
				}
				set	
				{
					defaultSelected = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}
		}

		public class DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode
		{

			private string ispName;

			private string ispCode;

			private string cityName;

			private string cityCode;

			private bool? defaultSelected;

			private string groupType;

			private string groupName;

			public string IspName
			{
				get
				{
					return ispName;
				}
				set	
				{
					ispName = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public bool? DefaultSelected
			{
				get
				{
					return defaultSelected;
				}
				set	
				{
					defaultSelected = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}
		}

		public class DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode
		{

			private string ispName;

			private string ispCode;

			private string cityName;

			private string cityCode;

			private bool? defaultSelected;

			private string groupType;

			private string groupName;

			public string IspName
			{
				get
				{
					return ispName;
				}
				set	
				{
					ispName = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public bool? DefaultSelected
			{
				get
				{
					return defaultSelected;
				}
				set	
				{
					defaultSelected = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}
		}

		public class DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode
		{

			private string ispName;

			private string ispCode;

			private string cityName;

			private string cityCode;

			private bool? defaultSelected;

			private string groupType;

			private string groupName;

			public string IspName
			{
				get
				{
					return ispName;
				}
				set	
				{
					ispName = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public bool? DefaultSelected
			{
				get
				{
					return defaultSelected;
				}
				set	
				{
					defaultSelected = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}
		}
	}
}
