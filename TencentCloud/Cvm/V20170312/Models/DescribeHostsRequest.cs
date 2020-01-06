/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li> zone - String - 是否必填：否 - （过滤条件）按照可用区过滤。</li>
        /// <li> project-id - Integer - 是否必填：否 - （过滤条件）按照项目ID过滤。可通过调用 DescribeProject 查询已创建的项目列表或登录控制台进行查看；也可以调用 AddProject 创建新的项目。</li>
        /// <li> host-id - String - 是否必填：否 - （过滤条件）按照CDH ID过滤。CDH ID形如：host-11112222。</li>
        /// <li> host-name - String - 是否必填：否 - （过滤条件）按照CDH实例名称过滤。</li>
        /// <li> host-state - String - 是否必填：否 - （过滤条件）按照CDH实例状态进行过滤。（PENDING：创建中|LAUNCH_FAILURE：创建失败|RUNNING：运行中|EXPIRED：已过期）</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

