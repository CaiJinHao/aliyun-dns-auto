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
	public class DescribeGtmInstanceAddressPoolResponse : AcsResponse
	{

		private string requestId;

		private string addrPoolId;

		private string createTime;

		private long? createTimestamp;

		private string updateTime;

		private long? updateTimestamp;

		private int? addrCount;

		private int? minAvailableAddrNum;

		private string monitorConfigId;

		private string monitorStatus;

		private string name;

		private string status;

		private string type;

		private List<DescribeGtmInstanceAddressPool_Addr> addrs;

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

		public string AddrPoolId
		{
			get
			{
				return addrPoolId;
			}
			set	
			{
				addrPoolId = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? CreateTimestamp
		{
			get
			{
				return createTimestamp;
			}
			set	
			{
				createTimestamp = value;
			}
		}

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public long? UpdateTimestamp
		{
			get
			{
				return updateTimestamp;
			}
			set	
			{
				updateTimestamp = value;
			}
		}

		public int? AddrCount
		{
			get
			{
				return addrCount;
			}
			set	
			{
				addrCount = value;
			}
		}

		public int? MinAvailableAddrNum
		{
			get
			{
				return minAvailableAddrNum;
			}
			set	
			{
				minAvailableAddrNum = value;
			}
		}

		public string MonitorConfigId
		{
			get
			{
				return monitorConfigId;
			}
			set	
			{
				monitorConfigId = value;
			}
		}

		public string MonitorStatus
		{
			get
			{
				return monitorStatus;
			}
			set	
			{
				monitorStatus = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public List<DescribeGtmInstanceAddressPool_Addr> Addrs
		{
			get
			{
				return addrs;
			}
			set	
			{
				addrs = value;
			}
		}

		public class DescribeGtmInstanceAddressPool_Addr
		{

			private long? addrId;

			private string createTime;

			private long? createTimestamp;

			private string updateTime;

			private long? updateTimestamp;

			private string _value;

			private int? lbaWeight;

			private string mode;

			private string alertStatus;

			public long? AddrId
			{
				get
				{
					return addrId;
				}
				set	
				{
					addrId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? UpdateTimestamp
			{
				get
				{
					return updateTimestamp;
				}
				set	
				{
					updateTimestamp = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public int? LbaWeight
			{
				get
				{
					return lbaWeight;
				}
				set	
				{
					lbaWeight = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public string AlertStatus
			{
				get
				{
					return alertStatus;
				}
				set	
				{
					alertStatus = value;
				}
			}
		}
	}
}
