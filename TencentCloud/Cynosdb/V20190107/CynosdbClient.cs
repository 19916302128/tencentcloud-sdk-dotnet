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

namespace TencentCloud.Cynosdb.V20190107
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cynosdb.V20190107.Models;

   public class CynosdbClient : AbstractClient{

       private const string endpoint = "cynosdb.tencentcloudapi.com";
       private const string version = "2019-01-07";
       private const string sdkVersion = "SDK_NET_3.0.1041";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CynosdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CynosdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(ActivateInstance)用于恢复已隔离的实例访问。
        /// </summary>
        /// <param name="req"><see cref="ActivateInstanceRequest"/></param>
        /// <returns><see cref="ActivateInstanceResponse"/></returns>
        public Task<ActivateInstanceResponse> ActivateInstance(ActivateInstanceRequest req)
        {
            return InternalRequestAsync<ActivateInstanceResponse>(req, "ActivateInstance");
        }

        /// <summary>
        /// 本接口(ActivateInstance)用于恢复已隔离的实例访问。
        /// </summary>
        /// <param name="req"><see cref="ActivateInstanceRequest"/></param>
        /// <returns><see cref="ActivateInstanceResponse"/></returns>
        public ActivateInstanceResponse ActivateInstanceSync(ActivateInstanceRequest req)
        {
            return InternalRequestAsync<ActivateInstanceResponse>(req, "ActivateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启多可用区部署
        /// </summary>
        /// <param name="req"><see cref="AddClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="AddClusterSlaveZoneResponse"/></returns>
        public Task<AddClusterSlaveZoneResponse> AddClusterSlaveZone(AddClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<AddClusterSlaveZoneResponse>(req, "AddClusterSlaveZone");
        }

        /// <summary>
        /// 开启多可用区部署
        /// </summary>
        /// <param name="req"><see cref="AddClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="AddClusterSlaveZoneResponse"/></returns>
        public AddClusterSlaveZoneResponse AddClusterSlaveZoneSync(AddClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<AddClusterSlaveZoneResponse>(req, "AddClusterSlaveZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AddInstances）用于集群添加实例
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public Task<AddInstancesResponse> AddInstances(AddInstancesRequest req)
        {
            return InternalRequestAsync<AddInstancesResponse>(req, "AddInstances");
        }

        /// <summary>
        /// 本接口（AddInstances）用于集群添加实例
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public AddInstancesResponse AddInstancesSync(AddInstancesRequest req)
        {
            return InternalRequestAsync<AddInstancesResponse>(req, "AddInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全组批量绑定云资源
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 安全组批量绑定云资源
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为集群绑定资源包
        /// </summary>
        /// <param name="req"><see cref="BindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="BindClusterResourcePackagesResponse"/></returns>
        public Task<BindClusterResourcePackagesResponse> BindClusterResourcePackages(BindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<BindClusterResourcePackagesResponse>(req, "BindClusterResourcePackages");
        }

        /// <summary>
        /// 为集群绑定资源包
        /// </summary>
        /// <param name="req"><see cref="BindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="BindClusterResourcePackagesResponse"/></returns>
        public BindClusterResourcePackagesResponse BindClusterResourcePackagesSync(BindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<BindClusterResourcePackagesResponse>(req, "BindClusterResourcePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TDSQL-C for MySQL实例关闭审计服务
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// TDSQL-C for MySQL实例关闭审计服务
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseClusterPasswordComplexity）用于关闭集群密码复杂度
        /// </summary>
        /// <param name="req"><see cref="CloseClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CloseClusterPasswordComplexityResponse"/></returns>
        public Task<CloseClusterPasswordComplexityResponse> CloseClusterPasswordComplexity(CloseClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CloseClusterPasswordComplexityResponse>(req, "CloseClusterPasswordComplexity");
        }

        /// <summary>
        /// 本接口（CloseClusterPasswordComplexity）用于关闭集群密码复杂度
        /// </summary>
        /// <param name="req"><see cref="CloseClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CloseClusterPasswordComplexityResponse"/></returns>
        public CloseClusterPasswordComplexityResponse CloseClusterPasswordComplexitySync(CloseClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CloseClusterPasswordComplexityResponse>(req, "CloseClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭数据库代理
        /// </summary>
        /// <param name="req"><see cref="CloseProxyRequest"/></param>
        /// <returns><see cref="CloseProxyResponse"/></returns>
        public Task<CloseProxyResponse> CloseProxy(CloseProxyRequest req)
        {
            return InternalRequestAsync<CloseProxyResponse>(req, "CloseProxy");
        }

        /// <summary>
        /// 关闭数据库代理
        /// </summary>
        /// <param name="req"><see cref="CloseProxyRequest"/></param>
        /// <returns><see cref="CloseProxyResponse"/></returns>
        public CloseProxyResponse CloseProxySync(CloseProxyRequest req)
        {
            return InternalRequestAsync<CloseProxyResponse>(req, "CloseProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseWan）用于关闭外网
        /// </summary>
        /// <param name="req"><see cref="CloseWanRequest"/></param>
        /// <returns><see cref="CloseWanResponse"/></returns>
        public Task<CloseWanResponse> CloseWan(CloseWanRequest req)
        {
            return InternalRequestAsync<CloseWanResponse>(req, "CloseWan");
        }

        /// <summary>
        /// 本接口（CloseWan）用于关闭外网
        /// </summary>
        /// <param name="req"><see cref="CloseWanRequest"/></param>
        /// <returns><see cref="CloseWanResponse"/></returns>
        public CloseWanResponse CloseWanSync(CloseWanRequest req)
        {
            return InternalRequestAsync<CloseWanResponse>(req, "CloseWan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CopyClusterPasswordComplexity）用于复制集群密码复杂度
        /// </summary>
        /// <param name="req"><see cref="CopyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CopyClusterPasswordComplexityResponse"/></returns>
        public Task<CopyClusterPasswordComplexityResponse> CopyClusterPasswordComplexity(CopyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CopyClusterPasswordComplexityResponse>(req, "CopyClusterPasswordComplexity");
        }

        /// <summary>
        /// 本接口（CopyClusterPasswordComplexity）用于复制集群密码复杂度
        /// </summary>
        /// <param name="req"><see cref="CopyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CopyClusterPasswordComplexityResponse"/></returns>
        public CopyClusterPasswordComplexityResponse CopyClusterPasswordComplexitySync(CopyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CopyClusterPasswordComplexityResponse>(req, "CopyClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public Task<CreateAccountsResponse> CreateAccounts(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts");
        }

        /// <summary>
        /// 创建用户账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public CreateAccountsResponse CreateAccountsSync(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAuditLogFile)用于创建云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public Task<CreateAuditLogFileResponse> CreateAuditLogFile(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile");
        }

        /// <summary>
        /// 本接口(CreateAuditLogFile)用于创建云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public CreateAuditLogFileResponse CreateAuditLogFileSync(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建审计规则模板
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public Task<CreateAuditRuleTemplateResponse> CreateAuditRuleTemplate(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate");
        }

        /// <summary>
        /// 创建审计规则模板
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public CreateAuditRuleTemplateResponse CreateAuditRuleTemplateSync(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为集群创建手动备份
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// 为集群创建手动备份
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建日志投递
        /// </summary>
        /// <param name="req"><see cref="CreateCLSDeliveryRequest"/></param>
        /// <returns><see cref="CreateCLSDeliveryResponse"/></returns>
        public Task<CreateCLSDeliveryResponse> CreateCLSDelivery(CreateCLSDeliveryRequest req)
        {
            return InternalRequestAsync<CreateCLSDeliveryResponse>(req, "CreateCLSDelivery");
        }

        /// <summary>
        /// 创建日志投递
        /// </summary>
        /// <param name="req"><see cref="CreateCLSDeliveryRequest"/></param>
        /// <returns><see cref="CreateCLSDeliveryResponse"/></returns>
        public CreateCLSDeliveryResponse CreateCLSDeliverySync(CreateCLSDeliveryRequest req)
        {
            return InternalRequestAsync<CreateCLSDeliveryResponse>(req, "CreateCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="req"><see cref="CreateClusterDatabaseRequest"/></param>
        /// <returns><see cref="CreateClusterDatabaseResponse"/></returns>
        public Task<CreateClusterDatabaseResponse> CreateClusterDatabase(CreateClusterDatabaseRequest req)
        {
            return InternalRequestAsync<CreateClusterDatabaseResponse>(req, "CreateClusterDatabase");
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="req"><see cref="CreateClusterDatabaseRequest"/></param>
        /// <returns><see cref="CreateClusterDatabaseResponse"/></returns>
        public CreateClusterDatabaseResponse CreateClusterDatabaseSync(CreateClusterDatabaseRequest req)
        {
            return InternalRequestAsync<CreateClusterDatabaseResponse>(req, "CreateClusterDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买新集群
        /// </summary>
        /// <param name="req"><see cref="CreateClustersRequest"/></param>
        /// <returns><see cref="CreateClustersResponse"/></returns>
        public Task<CreateClustersResponse> CreateClusters(CreateClustersRequest req)
        {
            return InternalRequestAsync<CreateClustersResponse>(req, "CreateClusters");
        }

        /// <summary>
        /// 购买新集群
        /// </summary>
        /// <param name="req"><see cref="CreateClustersRequest"/></param>
        /// <returns><see cref="CreateClustersResponse"/></returns>
        public CreateClustersResponse CreateClustersSync(CreateClustersRequest req)
        {
            return InternalRequestAsync<CreateClustersResponse>(req, "CreateClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateParamTemplate）用于创建参数模板
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate");
        }

        /// <summary>
        /// 本接口（CreateParamTemplate）用于创建参数模板
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据库代理
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public Task<CreateProxyResponse> CreateProxy(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy");
        }

        /// <summary>
        /// 创建数据库代理
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public CreateProxyResponse CreateProxySync(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据库代理连接点
        /// </summary>
        /// <param name="req"><see cref="CreateProxyEndPointRequest"/></param>
        /// <returns><see cref="CreateProxyEndPointResponse"/></returns>
        public Task<CreateProxyEndPointResponse> CreateProxyEndPoint(CreateProxyEndPointRequest req)
        {
            return InternalRequestAsync<CreateProxyEndPointResponse>(req, "CreateProxyEndPoint");
        }

        /// <summary>
        /// 创建数据库代理连接点
        /// </summary>
        /// <param name="req"><see cref="CreateProxyEndPointRequest"/></param>
        /// <returns><see cref="CreateProxyEndPointResponse"/></returns>
        public CreateProxyEndPointResponse CreateProxyEndPointSync(CreateProxyEndPointRequest req)
        {
            return InternalRequestAsync<CreateProxyEndPointResponse>(req, "CreateProxyEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新购资源包
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePackageRequest"/></param>
        /// <returns><see cref="CreateResourcePackageResponse"/></returns>
        public Task<CreateResourcePackageResponse> CreateResourcePackage(CreateResourcePackageRequest req)
        {
            return InternalRequestAsync<CreateResourcePackageResponse>(req, "CreateResourcePackage");
        }

        /// <summary>
        /// 新购资源包
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePackageRequest"/></param>
        /// <returns><see cref="CreateResourcePackageResponse"/></returns>
        public CreateResourcePackageResponse CreateResourcePackageSync(CreateResourcePackageRequest req)
        {
            return InternalRequestAsync<CreateResourcePackageResponse>(req, "CreateResourcePackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户账号
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public Task<DeleteAccountsResponse> DeleteAccounts(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts");
        }

        /// <summary>
        /// 删除用户账号
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public DeleteAccountsResponse DeleteAccountsSync(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteAuditLogFile)用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public Task<DeleteAuditLogFileResponse> DeleteAuditLogFile(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile");
        }

        /// <summary>
        /// 本接口(DeleteAuditLogFile)用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public DeleteAuditLogFileResponse DeleteAuditLogFileSync(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除审计规则模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleTemplatesResponse"/></returns>
        public Task<DeleteAuditRuleTemplatesResponse> DeleteAuditRuleTemplates(DeleteAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleTemplatesResponse>(req, "DeleteAuditRuleTemplates");
        }

        /// <summary>
        /// 删除审计规则模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleTemplatesResponse"/></returns>
        public DeleteAuditRuleTemplatesResponse DeleteAuditRuleTemplatesSync(DeleteAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleTemplatesResponse>(req, "DeleteAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为集群删除手动备份，无法删除自动备份
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup");
        }

        /// <summary>
        /// 为集群删除手动备份，无法删除自动备份
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public DeleteBackupResponse DeleteBackupSync(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除日志投递
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSDeliveryRequest"/></param>
        /// <returns><see cref="DeleteCLSDeliveryResponse"/></returns>
        public Task<DeleteCLSDeliveryResponse> DeleteCLSDelivery(DeleteCLSDeliveryRequest req)
        {
            return InternalRequestAsync<DeleteCLSDeliveryResponse>(req, "DeleteCLSDelivery");
        }

        /// <summary>
        /// 删除日志投递
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSDeliveryRequest"/></param>
        /// <returns><see cref="DeleteCLSDeliveryResponse"/></returns>
        public DeleteCLSDeliveryResponse DeleteCLSDeliverySync(DeleteCLSDeliveryRequest req)
        {
            return InternalRequestAsync<DeleteCLSDeliveryResponse>(req, "DeleteCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterDatabaseRequest"/></param>
        /// <returns><see cref="DeleteClusterDatabaseResponse"/></returns>
        public Task<DeleteClusterDatabaseResponse> DeleteClusterDatabase(DeleteClusterDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteClusterDatabaseResponse>(req, "DeleteClusterDatabase");
        }

        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterDatabaseRequest"/></param>
        /// <returns><see cref="DeleteClusterDatabaseResponse"/></returns>
        public DeleteClusterDatabaseResponse DeleteClusterDatabaseSync(DeleteClusterDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteClusterDatabaseResponse>(req, "DeleteClusterDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteParamTemplate）用于删除用户创建的参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate");
        }

        /// <summary>
        /// 本接口（DeleteParamTemplate）用于删除用户创建的参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号所有可授予权限
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAllGrantPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountAllGrantPrivilegesResponse"/></returns>
        public Task<DescribeAccountAllGrantPrivilegesResponse> DescribeAccountAllGrantPrivileges(DescribeAccountAllGrantPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountAllGrantPrivilegesResponse>(req, "DescribeAccountAllGrantPrivileges");
        }

        /// <summary>
        /// 查询账号所有可授予权限
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAllGrantPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountAllGrantPrivilegesResponse"/></returns>
        public DescribeAccountAllGrantPrivilegesResponse DescribeAccountAllGrantPrivilegesSync(DescribeAccountAllGrantPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountAllGrantPrivilegesResponse>(req, "DescribeAccountAllGrantPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号已有权限
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// 查询账号已有权限
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAccounts)用于查询数据库账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 本接口(DescribeAccounts)用于查询数据库账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// 获取审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditLogFiles)用于查询云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public Task<DescribeAuditLogFilesResponse> DescribeAuditLogFiles(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles");
        }

        /// <summary>
        /// 本接口(DescribeAuditLogFiles)用于查询云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public DescribeAuditLogFilesResponse DescribeAuditLogFilesSync(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditLogs)用于查询数据库审计日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public Task<DescribeAuditLogsResponse> DescribeAuditLogs(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs");
        }

        /// <summary>
        /// 本接口(DescribeAuditLogs)用于查询数据库审计日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public DescribeAuditLogsResponse DescribeAuditLogsSync(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询审计规则模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public Task<DescribeAuditRuleTemplatesResponse> DescribeAuditRuleTemplates(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates");
        }

        /// <summary>
        /// 查询审计规则模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public DescribeAuditRuleTemplatesResponse DescribeAuditRuleTemplatesSync(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例的审计规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleWithInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleWithInstanceIdsResponse"/></returns>
        public Task<DescribeAuditRuleWithInstanceIdsResponse> DescribeAuditRuleWithInstanceIds(DescribeAuditRuleWithInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleWithInstanceIdsResponse>(req, "DescribeAuditRuleWithInstanceIds");
        }

        /// <summary>
        /// 获取实例的审计规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleWithInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleWithInstanceIdsResponse"/></returns>
        public DescribeAuditRuleWithInstanceIdsResponse DescribeAuditRuleWithInstanceIdsSync(DescribeAuditRuleWithInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleWithInstanceIdsResponse>(req, "DescribeAuditRuleWithInstanceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定集群的备份配置信息，包括全量备份时间段，备份文件保留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig");
        }

        /// <summary>
        /// 获取指定集群的备份配置信息，包括全量备份时间段，备份文件保留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeBackupDownloadUrl）用于查询集群备份文件下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadUrlResponse"/></returns>
        public Task<DescribeBackupDownloadUrlResponse> DescribeBackupDownloadUrl(DescribeBackupDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadUrlResponse>(req, "DescribeBackupDownloadUrl");
        }

        /// <summary>
        /// 此接口（DescribeBackupDownloadUrl）用于查询集群备份文件下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadUrlResponse"/></returns>
        public DescribeBackupDownloadUrlResponse DescribeBackupDownloadUrlSync(DescribeBackupDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadUrlResponse>(req, "DescribeBackupDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListRequest"/></param>
        /// <returns><see cref="DescribeBackupListResponse"/></returns>
        public Task<DescribeBackupListResponse> DescribeBackupList(DescribeBackupListRequest req)
        {
            return InternalRequestAsync<DescribeBackupListResponse>(req, "DescribeBackupList");
        }

        /// <summary>
        /// 查询备份文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListRequest"/></param>
        /// <returns><see cref="DescribeBackupListResponse"/></returns>
        public DescribeBackupListResponse DescribeBackupListSync(DescribeBackupListRequest req)
        {
            return InternalRequestAsync<DescribeBackupListResponse>(req, "DescribeBackupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeBinlogDownloadUrl）用于查询Binlog的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBinlogDownloadUrlResponse"/></returns>
        public Task<DescribeBinlogDownloadUrlResponse> DescribeBinlogDownloadUrl(DescribeBinlogDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBinlogDownloadUrlResponse>(req, "DescribeBinlogDownloadUrl");
        }

        /// <summary>
        /// 此接口（DescribeBinlogDownloadUrl）用于查询Binlog的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBinlogDownloadUrlResponse"/></returns>
        public DescribeBinlogDownloadUrlResponse DescribeBinlogDownloadUrlSync(DescribeBinlogDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBinlogDownloadUrlResponse>(req, "DescribeBinlogDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeBinlogSaveDays）用于查询集群的Binlog保留天数。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="DescribeBinlogSaveDaysResponse"/></returns>
        public Task<DescribeBinlogSaveDaysResponse> DescribeBinlogSaveDays(DescribeBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<DescribeBinlogSaveDaysResponse>(req, "DescribeBinlogSaveDays");
        }

        /// <summary>
        /// 此接口（DescribeBinlogSaveDays）用于查询集群的Binlog保留天数。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="DescribeBinlogSaveDaysResponse"/></returns>
        public DescribeBinlogSaveDaysResponse DescribeBinlogSaveDaysSync(DescribeBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<DescribeBinlogSaveDaysResponse>(req, "DescribeBinlogSaveDays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeBinlogs）用来查询集群Binlog日志列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public Task<DescribeBinlogsResponse> DescribeBinlogs(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs");
        }

        /// <summary>
        /// 此接口（DescribeBinlogs）用来查询集群Binlog日志列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public DescribeBinlogsResponse DescribeBinlogsSync(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeChangedParamsAfterUpgrade）用于查询升降配运行参数对比
        /// </summary>
        /// <param name="req"><see cref="DescribeChangedParamsAfterUpgradeRequest"/></param>
        /// <returns><see cref="DescribeChangedParamsAfterUpgradeResponse"/></returns>
        public Task<DescribeChangedParamsAfterUpgradeResponse> DescribeChangedParamsAfterUpgrade(DescribeChangedParamsAfterUpgradeRequest req)
        {
            return InternalRequestAsync<DescribeChangedParamsAfterUpgradeResponse>(req, "DescribeChangedParamsAfterUpgrade");
        }

        /// <summary>
        /// 本接口（DescribeChangedParamsAfterUpgrade）用于查询升降配运行参数对比
        /// </summary>
        /// <param name="req"><see cref="DescribeChangedParamsAfterUpgradeRequest"/></param>
        /// <returns><see cref="DescribeChangedParamsAfterUpgradeResponse"/></returns>
        public DescribeChangedParamsAfterUpgradeResponse DescribeChangedParamsAfterUpgradeSync(DescribeChangedParamsAfterUpgradeRequest req)
        {
            return InternalRequestAsync<DescribeChangedParamsAfterUpgradeResponse>(req, "DescribeChangedParamsAfterUpgrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDatabasesResponse"/></returns>
        public Task<DescribeClusterDatabasesResponse> DescribeClusterDatabases(DescribeClusterDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDatabasesResponse>(req, "DescribeClusterDatabases");
        }

        /// <summary>
        /// 获取集群数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDatabasesResponse"/></returns>
        public DescribeClusterDatabasesResponse DescribeClusterDatabasesSync(DescribeClusterDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDatabasesResponse>(req, "DescribeClusterDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeClusterDetail）显示集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// 该接口（DescribeClusterDetail）显示集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailDatabasesResponse"/></returns>
        public Task<DescribeClusterDetailDatabasesResponse> DescribeClusterDetailDatabases(DescribeClusterDetailDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailDatabasesResponse>(req, "DescribeClusterDetailDatabases");
        }

        /// <summary>
        /// 查询数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailDatabasesResponse"/></returns>
        public DescribeClusterDetailDatabasesResponse DescribeClusterDetailDatabasesSync(DescribeClusterDetailDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailDatabasesResponse>(req, "DescribeClusterDetailDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusterInstanceGrps）用于查询实例组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGroupsResponse"/></returns>
        public Task<DescribeClusterInstanceGroupsResponse> DescribeClusterInstanceGroups(DescribeClusterInstanceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstanceGroupsResponse>(req, "DescribeClusterInstanceGroups");
        }

        /// <summary>
        /// 本接口（DescribeClusterInstanceGrps）用于查询实例组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGroupsResponse"/></returns>
        public DescribeClusterInstanceGroupsResponse DescribeClusterInstanceGroupsSync(DescribeClusterInstanceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstanceGroupsResponse>(req, "DescribeClusterInstanceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusterInstanceGrps）用于查询实例组信息。 该接口已废弃，推荐使用DescribeClusterInstanceGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGrpsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGrpsResponse"/></returns>
        public Task<DescribeClusterInstanceGrpsResponse> DescribeClusterInstanceGrps(DescribeClusterInstanceGrpsRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstanceGrpsResponse>(req, "DescribeClusterInstanceGrps");
        }

        /// <summary>
        /// 本接口（DescribeClusterInstanceGrps）用于查询实例组信息。 该接口已废弃，推荐使用DescribeClusterInstanceGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGrpsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGrpsResponse"/></returns>
        public DescribeClusterInstanceGrpsResponse DescribeClusterInstanceGrpsSync(DescribeClusterInstanceGrpsRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstanceGrpsResponse>(req, "DescribeClusterInstanceGrps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusterParamLogs）查询参数修改记录
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterParamLogsRequest"/></param>
        /// <returns><see cref="DescribeClusterParamLogsResponse"/></returns>
        public Task<DescribeClusterParamLogsResponse> DescribeClusterParamLogs(DescribeClusterParamLogsRequest req)
        {
            return InternalRequestAsync<DescribeClusterParamLogsResponse>(req, "DescribeClusterParamLogs");
        }

        /// <summary>
        /// 本接口（DescribeClusterParamLogs）查询参数修改记录
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterParamLogsRequest"/></param>
        /// <returns><see cref="DescribeClusterParamLogsResponse"/></returns>
        public DescribeClusterParamLogsResponse DescribeClusterParamLogsSync(DescribeClusterParamLogsRequest req)
        {
            return InternalRequestAsync<DescribeClusterParamLogsResponse>(req, "DescribeClusterParamLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusterParams）用于查询集群参数
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterParamsRequest"/></param>
        /// <returns><see cref="DescribeClusterParamsResponse"/></returns>
        public Task<DescribeClusterParamsResponse> DescribeClusterParams(DescribeClusterParamsRequest req)
        {
            return InternalRequestAsync<DescribeClusterParamsResponse>(req, "DescribeClusterParams");
        }

        /// <summary>
        /// 本接口（DescribeClusterParams）用于查询集群参数
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterParamsRequest"/></param>
        /// <returns><see cref="DescribeClusterParamsResponse"/></returns>
        public DescribeClusterParamsResponse DescribeClusterParamsSync(DescribeClusterParamsRequest req)
        {
            return InternalRequestAsync<DescribeClusterParamsResponse>(req, "DescribeClusterParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusterPasswordComplexity）用于查看集群密码复杂度详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="DescribeClusterPasswordComplexityResponse"/></returns>
        public Task<DescribeClusterPasswordComplexityResponse> DescribeClusterPasswordComplexity(DescribeClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<DescribeClusterPasswordComplexityResponse>(req, "DescribeClusterPasswordComplexity");
        }

        /// <summary>
        /// 本接口（DescribeClusterPasswordComplexity）用于查看集群密码复杂度详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="DescribeClusterPasswordComplexityResponse"/></returns>
        public DescribeClusterPasswordComplexityResponse DescribeClusterPasswordComplexitySync(DescribeClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<DescribeClusterPasswordComplexityResponse>(req, "DescribeClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// 查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询任务流信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询任务流信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例日志投递信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCLSLogDeliveryRequest"/></param>
        /// <returns><see cref="DescribeInstanceCLSLogDeliveryResponse"/></returns>
        public Task<DescribeInstanceCLSLogDeliveryResponse> DescribeInstanceCLSLogDelivery(DescribeInstanceCLSLogDeliveryRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCLSLogDeliveryResponse>(req, "DescribeInstanceCLSLogDelivery");
        }

        /// <summary>
        /// 查询实例日志投递信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCLSLogDeliveryRequest"/></param>
        /// <returns><see cref="DescribeInstanceCLSLogDeliveryResponse"/></returns>
        public DescribeInstanceCLSLogDeliveryResponse DescribeInstanceCLSLogDeliverySync(DescribeInstanceCLSLogDeliveryRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCLSLogDeliveryResponse>(req, "DescribeInstanceCLSLogDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeInstanceDetail)用于查询实例详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public Task<DescribeInstanceDetailResponse> DescribeInstanceDetail(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail");
        }

        /// <summary>
        /// 本接口(DescribeInstanceDetail)用于查询实例详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public DescribeInstanceDetailResponse DescribeInstanceDetailSync(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例错误日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceErrorLogsResponse"/></returns>
        public Task<DescribeInstanceErrorLogsResponse> DescribeInstanceErrorLogs(DescribeInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceErrorLogsResponse>(req, "DescribeInstanceErrorLogs");
        }

        /// <summary>
        /// 查询实例错误日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceErrorLogsResponse"/></returns>
        public DescribeInstanceErrorLogsResponse DescribeInstanceErrorLogsSync(DescribeInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceErrorLogsResponse>(req, "DescribeInstanceErrorLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口(DescribeInstanceParams)查询实例参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// 该接口(DescribeInstanceParams)查询实例参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeInstanceSlowQueries）用于查询实例慢日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceSlowQueriesResponse"/></returns>
        public Task<DescribeInstanceSlowQueriesResponse> DescribeInstanceSlowQueries(DescribeInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSlowQueriesResponse>(req, "DescribeInstanceSlowQueries");
        }

        /// <summary>
        /// 此接口（DescribeInstanceSlowQueries）用于查询实例慢日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceSlowQueriesResponse"/></returns>
        public DescribeInstanceSlowQueriesResponse DescribeInstanceSlowQueriesSync(DescribeInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSlowQueriesResponse>(req, "DescribeInstanceSlowQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceSpecs）用于查询购买页可购买的实例规格
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsResponse"/></returns>
        public Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecs(DescribeInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSpecsResponse>(req, "DescribeInstanceSpecs");
        }

        /// <summary>
        /// 本接口（DescribeInstanceSpecs）用于查询购买页可购买的实例规格
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsResponse"/></returns>
        public DescribeInstanceSpecsResponse DescribeInstanceSpecsSync(DescribeInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSpecsResponse>(req, "DescribeInstanceSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 本接口(DescribeInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例维护时间窗
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainPeriodRequest"/></param>
        /// <returns><see cref="DescribeMaintainPeriodResponse"/></returns>
        public Task<DescribeMaintainPeriodResponse> DescribeMaintainPeriod(DescribeMaintainPeriodRequest req)
        {
            return InternalRequestAsync<DescribeMaintainPeriodResponse>(req, "DescribeMaintainPeriod");
        }

        /// <summary>
        /// 查询实例维护时间窗
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainPeriodRequest"/></param>
        /// <returns><see cref="DescribeMaintainPeriodResponse"/></returns>
        public DescribeMaintainPeriodResponse DescribeMaintainPeriodSync(DescribeMaintainPeriodRequest req)
        {
            return InternalRequestAsync<DescribeMaintainPeriodResponse>(req, "DescribeMaintainPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeParamTemplateDetail）用于查询用户参数模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateDetailResponse"/></returns>
        public Task<DescribeParamTemplateDetailResponse> DescribeParamTemplateDetail(DescribeParamTemplateDetailRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateDetailResponse>(req, "DescribeParamTemplateDetail");
        }

        /// <summary>
        /// 本接口（DescribeParamTemplateDetail）用于查询用户参数模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateDetailResponse"/></returns>
        public DescribeParamTemplateDetailResponse DescribeParamTemplateDetailSync(DescribeParamTemplateDetailRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateDetailResponse>(req, "DescribeParamTemplateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户指定产品下的所有参数模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates");
        }

        /// <summary>
        /// 查询用户指定产品下的所有参数模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据库代理列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public Task<DescribeProxiesResponse> DescribeProxies(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies");
        }

        /// <summary>
        /// 查询数据库代理列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public DescribeProxiesResponse DescribeProxiesSync(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxyNodes）用于查询代理节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyNodesRequest"/></param>
        /// <returns><see cref="DescribeProxyNodesResponse"/></returns>
        public Task<DescribeProxyNodesResponse> DescribeProxyNodes(DescribeProxyNodesRequest req)
        {
            return InternalRequestAsync<DescribeProxyNodesResponse>(req, "DescribeProxyNodes");
        }

        /// <summary>
        /// 本接口（DescribeProxyNodes）用于查询代理节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyNodesRequest"/></param>
        /// <returns><see cref="DescribeProxyNodesResponse"/></returns>
        public DescribeProxyNodesResponse DescribeProxyNodesSync(DescribeProxyNodesRequest req)
        {
            return InternalRequestAsync<DescribeProxyNodesResponse>(req, "DescribeProxyNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据库代理规格
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySpecsRequest"/></param>
        /// <returns><see cref="DescribeProxySpecsResponse"/></returns>
        public Task<DescribeProxySpecsResponse> DescribeProxySpecs(DescribeProxySpecsRequest req)
        {
            return InternalRequestAsync<DescribeProxySpecsResponse>(req, "DescribeProxySpecs");
        }

        /// <summary>
        /// 查询数据库代理规格
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySpecsRequest"/></param>
        /// <returns><see cref="DescribeProxySpecsResponse"/></returns>
        public DescribeProxySpecsResponse DescribeProxySpecsSync(DescribeProxySpecsRequest req)
        {
            return InternalRequestAsync<DescribeProxySpecsResponse>(req, "DescribeProxySpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源包使用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageDetailRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageDetailResponse"/></returns>
        public Task<DescribeResourcePackageDetailResponse> DescribeResourcePackageDetail(DescribeResourcePackageDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageDetailResponse>(req, "DescribeResourcePackageDetail");
        }

        /// <summary>
        /// 查询资源包使用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageDetailRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageDetailResponse"/></returns>
        public DescribeResourcePackageDetailResponse DescribeResourcePackageDetailSync(DescribeResourcePackageDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageDetailResponse>(req, "DescribeResourcePackageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageListRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageListResponse"/></returns>
        public Task<DescribeResourcePackageListResponse> DescribeResourcePackageList(DescribeResourcePackageListRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageListResponse>(req, "DescribeResourcePackageList");
        }

        /// <summary>
        /// 查询资源包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageListRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageListResponse"/></returns>
        public DescribeResourcePackageListResponse DescribeResourcePackageListSync(DescribeResourcePackageListRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageListResponse>(req, "DescribeResourcePackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源包规格
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageSaleSpecRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageSaleSpecResponse"/></returns>
        public Task<DescribeResourcePackageSaleSpecResponse> DescribeResourcePackageSaleSpec(DescribeResourcePackageSaleSpecRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageSaleSpecResponse>(req, "DescribeResourcePackageSaleSpec");
        }

        /// <summary>
        /// 查询资源包规格
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageSaleSpecRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageSaleSpecResponse"/></returns>
        public DescribeResourcePackageSaleSpecResponse DescribeResourcePackageSaleSpecSync(DescribeResourcePackageSaleSpecRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageSaleSpecResponse>(req, "DescribeResourcePackageSaleSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询订单关联实例
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public Task<DescribeResourcesByDealNameResponse> DescribeResourcesByDealName(DescribeResourcesByDealNameRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByDealNameResponse>(req, "DescribeResourcesByDealName");
        }

        /// <summary>
        /// 查询订单关联实例
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public DescribeResourcesByDealNameResponse DescribeResourcesByDealNameSync(DescribeResourcesByDealNameRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByDealNameResponse>(req, "DescribeResourcesByDealName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeRangeResponse"/></returns>
        public Task<DescribeRollbackTimeRangeResponse> DescribeRollbackTimeRange(DescribeRollbackTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeRangeResponse>(req, "DescribeRollbackTimeRange");
        }

        /// <summary>
        /// 查询回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeRangeResponse"/></returns>
        public DescribeRollbackTimeRangeResponse DescribeRollbackTimeRangeSync(DescribeRollbackTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeRangeResponse>(req, "DescribeRollbackTimeRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 历史废弃接口，从云API下线
        /// 
        /// 指定时间和集群查询是否可回滚
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeValidityRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeValidityResponse"/></returns>
        public Task<DescribeRollbackTimeValidityResponse> DescribeRollbackTimeValidity(DescribeRollbackTimeValidityRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeValidityResponse>(req, "DescribeRollbackTimeValidity");
        }

        /// <summary>
        /// 历史废弃接口，从云API下线
        /// 
        /// 指定时间和集群查询是否可回滚
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeValidityRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeValidityResponse"/></returns>
        public DescribeRollbackTimeValidityResponse DescribeRollbackTimeValiditySync(DescribeRollbackTimeValidityRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeValidityResponse>(req, "DescribeRollbackTimeValidity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询支持的数据库代理版本
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportProxyVersionRequest"/></param>
        /// <returns><see cref="DescribeSupportProxyVersionResponse"/></returns>
        public Task<DescribeSupportProxyVersionResponse> DescribeSupportProxyVersion(DescribeSupportProxyVersionRequest req)
        {
            return InternalRequestAsync<DescribeSupportProxyVersionResponse>(req, "DescribeSupportProxyVersion");
        }

        /// <summary>
        /// 查询支持的数据库代理版本
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportProxyVersionRequest"/></param>
        /// <returns><see cref="DescribeSupportProxyVersionResponse"/></returns>
        public DescribeSupportProxyVersionResponse DescribeSupportProxyVersionSync(DescribeSupportProxyVersionRequest req)
        {
            return InternalRequestAsync<DescribeSupportProxyVersionResponse>(req, "DescribeSupportProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeZones)用于查询可售卖地域可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 本接口(DescribeZones)用于查询可售卖地域可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全组批量解绑云资源
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// 安全组批量解绑云资源
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ExportInstanceErrorLogs）用于导出实例错误日志。
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="ExportInstanceErrorLogsResponse"/></returns>
        public Task<ExportInstanceErrorLogsResponse> ExportInstanceErrorLogs(ExportInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<ExportInstanceErrorLogsResponse>(req, "ExportInstanceErrorLogs");
        }

        /// <summary>
        /// 此接口（ExportInstanceErrorLogs）用于导出实例错误日志。
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="ExportInstanceErrorLogsResponse"/></returns>
        public ExportInstanceErrorLogsResponse ExportInstanceErrorLogsSync(ExportInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<ExportInstanceErrorLogsResponse>(req, "ExportInstanceErrorLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ExportInstanceSlowQueries）用于导出实例慢日志。
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="ExportInstanceSlowQueriesResponse"/></returns>
        public Task<ExportInstanceSlowQueriesResponse> ExportInstanceSlowQueries(ExportInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<ExportInstanceSlowQueriesResponse>(req, "ExportInstanceSlowQueries");
        }

        /// <summary>
        /// 此接口（ExportInstanceSlowQueries）用于导出实例慢日志。
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="ExportInstanceSlowQueriesResponse"/></returns>
        public ExportInstanceSlowQueriesResponse ExportInstanceSlowQueriesSync(ExportInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<ExportInstanceSlowQueriesResponse>(req, "ExportInstanceSlowQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量授权账号权限
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges");
        }

        /// <summary>
        /// 批量授权账号权限
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public GrantAccountPrivilegesResponse GrantAccountPrivilegesSync(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询新购集群价格
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateRequest"/></param>
        /// <returns><see cref="InquirePriceCreateResponse"/></returns>
        public Task<InquirePriceCreateResponse> InquirePriceCreate(InquirePriceCreateRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateResponse>(req, "InquirePriceCreate");
        }

        /// <summary>
        /// 查询新购集群价格
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateRequest"/></param>
        /// <returns><see cref="InquirePriceCreateResponse"/></returns>
        public InquirePriceCreateResponse InquirePriceCreateSync(InquirePriceCreateRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateResponse>(req, "InquirePriceCreate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询续费集群价格
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewRequest"/></param>
        /// <returns><see cref="InquirePriceRenewResponse"/></returns>
        public Task<InquirePriceRenewResponse> InquirePriceRenew(InquirePriceRenewRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewResponse>(req, "InquirePriceRenew");
        }

        /// <summary>
        /// 查询续费集群价格
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewRequest"/></param>
        /// <returns><see cref="InquirePriceRenewResponse"/></returns>
        public InquirePriceRenewResponse InquirePriceRenewSync(InquirePriceRenewRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewResponse>(req, "InquirePriceRenew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 隔离集群
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public Task<IsolateClusterResponse> IsolateCluster(IsolateClusterRequest req)
        {
            return InternalRequestAsync<IsolateClusterResponse>(req, "IsolateCluster");
        }

        /// <summary>
        /// 隔离集群
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public IsolateClusterResponse IsolateClusterSync(IsolateClusterRequest req)
        {
            return InternalRequestAsync<IsolateClusterResponse>(req, "IsolateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(IsolateInstance)用于隔离实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateInstanceRequest"/></param>
        /// <returns><see cref="IsolateInstanceResponse"/></returns>
        public Task<IsolateInstanceResponse> IsolateInstance(IsolateInstanceRequest req)
        {
            return InternalRequestAsync<IsolateInstanceResponse>(req, "IsolateInstance");
        }

        /// <summary>
        /// 本接口(IsolateInstance)用于隔离实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateInstanceRequest"/></param>
        /// <returns><see cref="IsolateInstanceResponse"/></returns>
        public IsolateInstanceResponse IsolateInstanceSync(IsolateInstanceRequest req)
        {
            return InternalRequestAsync<IsolateInstanceResponse>(req, "IsolateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountDescription)用于修改数据库账号描述信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// 本接口(ModifyAccountDescription)用于修改数据库账号描述信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改账号主机
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountHostRequest"/></param>
        /// <returns><see cref="ModifyAccountHostResponse"/></returns>
        public Task<ModifyAccountHostResponse> ModifyAccountHost(ModifyAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyAccountHostResponse>(req, "ModifyAccountHost");
        }

        /// <summary>
        /// 修改账号主机
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountHostRequest"/></param>
        /// <returns><see cref="ModifyAccountHostResponse"/></returns>
        public ModifyAccountHostResponse ModifyAccountHostSync(ModifyAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyAccountHostResponse>(req, "ModifyAccountHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改账号配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountParamsRequest"/></param>
        /// <returns><see cref="ModifyAccountParamsResponse"/></returns>
        public Task<ModifyAccountParamsResponse> ModifyAccountParams(ModifyAccountParamsRequest req)
        {
            return InternalRequestAsync<ModifyAccountParamsResponse>(req, "ModifyAccountParams");
        }

        /// <summary>
        /// 修改账号配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountParamsRequest"/></param>
        /// <returns><see cref="ModifyAccountParamsResponse"/></returns>
        public ModifyAccountParamsResponse ModifyAccountParamsSync(ModifyAccountParamsRequest req)
        {
            return InternalRequestAsync<ModifyAccountParamsResponse>(req, "ModifyAccountParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改账号库表权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// 修改账号库表权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改审计规则模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleTemplatesResponse"/></returns>
        public Task<ModifyAuditRuleTemplatesResponse> ModifyAuditRuleTemplates(ModifyAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleTemplatesResponse>(req, "ModifyAuditRuleTemplates");
        }

        /// <summary>
        /// 修改审计规则模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleTemplatesResponse"/></returns>
        public ModifyAuditRuleTemplatesResponse ModifyAuditRuleTemplatesSync(ModifyAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleTemplatesResponse>(req, "ModifyAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAuditService)用于修改云数据库审计日志保存时长、审计规则等服务配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// 本接口(ModifyAuditService)用于修改云数据库审计日志保存时长、审计规则等服务配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定集群的备份配置
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig");
        }

        /// <summary>
        /// 修改指定集群的备份配置
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ModifyBackupName）用于修改备份文件备注名。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public Task<ModifyBackupNameResponse> ModifyBackupName(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName");
        }

        /// <summary>
        /// 此接口（ModifyBackupName）用于修改备份文件备注名。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public ModifyBackupNameResponse ModifyBackupNameSync(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ModifyBinlogSaveDays）用于修改集群Binlog保留天数。
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="ModifyBinlogSaveDaysResponse"/></returns>
        public Task<ModifyBinlogSaveDaysResponse> ModifyBinlogSaveDays(ModifyBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<ModifyBinlogSaveDaysResponse>(req, "ModifyBinlogSaveDays");
        }

        /// <summary>
        /// 此接口（ModifyBinlogSaveDays）用于修改集群Binlog保留天数。
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="ModifyBinlogSaveDaysResponse"/></returns>
        public ModifyBinlogSaveDaysResponse ModifyBinlogSaveDaysSync(ModifyBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<ModifyBinlogSaveDaysResponse>(req, "ModifyBinlogSaveDays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据库
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDatabaseRequest"/></param>
        /// <returns><see cref="ModifyClusterDatabaseResponse"/></returns>
        public Task<ModifyClusterDatabaseResponse> ModifyClusterDatabase(ModifyClusterDatabaseRequest req)
        {
            return InternalRequestAsync<ModifyClusterDatabaseResponse>(req, "ModifyClusterDatabase");
        }

        /// <summary>
        /// 修改数据库
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDatabaseRequest"/></param>
        /// <returns><see cref="ModifyClusterDatabaseResponse"/></returns>
        public ModifyClusterDatabaseResponse ModifyClusterDatabaseSync(ModifyClusterDatabaseRequest req)
        {
            return InternalRequestAsync<ModifyClusterDatabaseResponse>(req, "ModifyClusterDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName");
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群参数
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterParamRequest"/></param>
        /// <returns><see cref="ModifyClusterParamResponse"/></returns>
        public Task<ModifyClusterParamResponse> ModifyClusterParam(ModifyClusterParamRequest req)
        {
            return InternalRequestAsync<ModifyClusterParamResponse>(req, "ModifyClusterParam");
        }

        /// <summary>
        /// 修改集群参数
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterParamRequest"/></param>
        /// <returns><see cref="ModifyClusterParamResponse"/></returns>
        public ModifyClusterParamResponse ModifyClusterParamSync(ModifyClusterParamRequest req)
        {
            return InternalRequestAsync<ModifyClusterParamResponse>(req, "ModifyClusterParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyClusterPasswordComplexity）用于修改/开启集群密码复杂度
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordComplexityResponse"/></returns>
        public Task<ModifyClusterPasswordComplexityResponse> ModifyClusterPasswordComplexity(ModifyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordComplexityResponse>(req, "ModifyClusterPasswordComplexity");
        }

        /// <summary>
        /// 本接口（ModifyClusterPasswordComplexity）用于修改/开启集群密码复杂度
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordComplexityResponse"/></returns>
        public ModifyClusterPasswordComplexityResponse ModifyClusterPasswordComplexitySync(ModifyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordComplexityResponse>(req, "ModifyClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变更备可用区
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="ModifyClusterSlaveZoneResponse"/></returns>
        public Task<ModifyClusterSlaveZoneResponse> ModifyClusterSlaveZone(ModifyClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<ModifyClusterSlaveZoneResponse>(req, "ModifyClusterSlaveZone");
        }

        /// <summary>
        /// 变更备可用区
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="ModifyClusterSlaveZoneResponse"/></returns>
        public ModifyClusterSlaveZoneResponse ModifyClusterSlaveZoneSync(ModifyClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<ModifyClusterSlaveZoneResponse>(req, "ModifyClusterSlaveZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整包年包月存储容量
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterStorageRequest"/></param>
        /// <returns><see cref="ModifyClusterStorageResponse"/></returns>
        public Task<ModifyClusterStorageResponse> ModifyClusterStorage(ModifyClusterStorageRequest req)
        {
            return InternalRequestAsync<ModifyClusterStorageResponse>(req, "ModifyClusterStorage");
        }

        /// <summary>
        /// 调整包年包月存储容量
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterStorageRequest"/></param>
        /// <returns><see cref="ModifyClusterStorageResponse"/></returns>
        public ModifyClusterStorageResponse ModifyClusterStorageSync(ModifyClusterStorageRequest req)
        {
            return InternalRequestAsync<ModifyClusterStorageResponse>(req, "ModifyClusterStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstanceName)用于修改实例名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName");
        }

        /// <summary>
        /// 本接口(ModifyInstanceName)用于修改实例名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceParam）用于修改实例参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam");
        }

        /// <summary>
        /// 本接口（ModifyInstanceParam）用于修改实例参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例小版本升级限制时间
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceUpgradeLimitDaysRequest"/></param>
        /// <returns><see cref="ModifyInstanceUpgradeLimitDaysResponse"/></returns>
        public Task<ModifyInstanceUpgradeLimitDaysResponse> ModifyInstanceUpgradeLimitDays(ModifyInstanceUpgradeLimitDaysRequest req)
        {
            return InternalRequestAsync<ModifyInstanceUpgradeLimitDaysResponse>(req, "ModifyInstanceUpgradeLimitDays");
        }

        /// <summary>
        /// 修改实例小版本升级限制时间
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceUpgradeLimitDaysRequest"/></param>
        /// <returns><see cref="ModifyInstanceUpgradeLimitDaysResponse"/></returns>
        public ModifyInstanceUpgradeLimitDaysResponse ModifyInstanceUpgradeLimitDaysSync(ModifyInstanceUpgradeLimitDaysRequest req)
        {
            return InternalRequestAsync<ModifyInstanceUpgradeLimitDaysResponse>(req, "ModifyInstanceUpgradeLimitDays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改维护时间配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainPeriodConfigRequest"/></param>
        /// <returns><see cref="ModifyMaintainPeriodConfigResponse"/></returns>
        public Task<ModifyMaintainPeriodConfigResponse> ModifyMaintainPeriodConfig(ModifyMaintainPeriodConfigRequest req)
        {
            return InternalRequestAsync<ModifyMaintainPeriodConfigResponse>(req, "ModifyMaintainPeriodConfig");
        }

        /// <summary>
        /// 修改维护时间配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainPeriodConfigRequest"/></param>
        /// <returns><see cref="ModifyMaintainPeriodConfigResponse"/></returns>
        public ModifyMaintainPeriodConfigResponse ModifyMaintainPeriodConfigSync(ModifyMaintainPeriodConfigRequest req)
        {
            return InternalRequestAsync<ModifyMaintainPeriodConfigResponse>(req, "ModifyMaintainPeriodConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyParamTemplate）用于修改用户参数模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate");
        }

        /// <summary>
        /// 本接口（ModifyParamTemplate）用于修改用户参数模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据库代理描述
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyDescRequest"/></param>
        /// <returns><see cref="ModifyProxyDescResponse"/></returns>
        public Task<ModifyProxyDescResponse> ModifyProxyDesc(ModifyProxyDescRequest req)
        {
            return InternalRequestAsync<ModifyProxyDescResponse>(req, "ModifyProxyDesc");
        }

        /// <summary>
        /// 修改数据库代理描述
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyDescRequest"/></param>
        /// <returns><see cref="ModifyProxyDescResponse"/></returns>
        public ModifyProxyDescResponse ModifyProxyDescSync(ModifyProxyDescRequest req)
        {
            return InternalRequestAsync<ModifyProxyDescResponse>(req, "ModifyProxyDesc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置数据库代理读写分离
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyRwSplitRequest"/></param>
        /// <returns><see cref="ModifyProxyRwSplitResponse"/></returns>
        public Task<ModifyProxyRwSplitResponse> ModifyProxyRwSplit(ModifyProxyRwSplitRequest req)
        {
            return InternalRequestAsync<ModifyProxyRwSplitResponse>(req, "ModifyProxyRwSplit");
        }

        /// <summary>
        /// 配置数据库代理读写分离
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyRwSplitRequest"/></param>
        /// <returns><see cref="ModifyProxyRwSplitResponse"/></returns>
        public ModifyProxyRwSplitResponse ModifyProxyRwSplitSync(ModifyProxyRwSplitRequest req)
        {
            return InternalRequestAsync<ModifyProxyRwSplitResponse>(req, "ModifyProxyRwSplit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 给资源包绑定集群
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageClustersRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageClustersResponse"/></returns>
        public Task<ModifyResourcePackageClustersResponse> ModifyResourcePackageClusters(ModifyResourcePackageClustersRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageClustersResponse>(req, "ModifyResourcePackageClusters");
        }

        /// <summary>
        /// 给资源包绑定集群
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageClustersRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageClustersResponse"/></returns>
        public ModifyResourcePackageClustersResponse ModifyResourcePackageClustersSync(ModifyResourcePackageClustersRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageClustersResponse>(req, "ModifyResourcePackageClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资源包名称
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageNameRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageNameResponse"/></returns>
        public Task<ModifyResourcePackageNameResponse> ModifyResourcePackageName(ModifyResourcePackageNameRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageNameResponse>(req, "ModifyResourcePackageName");
        }

        /// <summary>
        /// 修改资源包名称
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageNameRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageNameResponse"/></returns>
        public ModifyResourcePackageNameResponse ModifyResourcePackageNameSync(ModifyResourcePackageNameRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageNameResponse>(req, "ModifyResourcePackageName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例组ip，端口
        /// </summary>
        /// <param name="req"><see cref="ModifyVipVportRequest"/></param>
        /// <returns><see cref="ModifyVipVportResponse"/></returns>
        public Task<ModifyVipVportResponse> ModifyVipVport(ModifyVipVportRequest req)
        {
            return InternalRequestAsync<ModifyVipVportResponse>(req, "ModifyVipVport");
        }

        /// <summary>
        /// 修改实例组ip，端口
        /// </summary>
        /// <param name="req"><see cref="ModifyVipVportRequest"/></param>
        /// <returns><see cref="ModifyVipVportResponse"/></returns>
        public ModifyVipVportResponse ModifyVipVportSync(ModifyVipVportRequest req)
        {
            return InternalRequestAsync<ModifyVipVportResponse>(req, "ModifyVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="OfflineClusterRequest"/></param>
        /// <returns><see cref="OfflineClusterResponse"/></returns>
        public Task<OfflineClusterResponse> OfflineCluster(OfflineClusterRequest req)
        {
            return InternalRequestAsync<OfflineClusterResponse>(req, "OfflineCluster");
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="OfflineClusterRequest"/></param>
        /// <returns><see cref="OfflineClusterResponse"/></returns>
        public OfflineClusterResponse OfflineClusterSync(OfflineClusterRequest req)
        {
            return InternalRequestAsync<OfflineClusterResponse>(req, "OfflineCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="OfflineInstanceRequest"/></param>
        /// <returns><see cref="OfflineInstanceResponse"/></returns>
        public Task<OfflineInstanceResponse> OfflineInstance(OfflineInstanceRequest req)
        {
            return InternalRequestAsync<OfflineInstanceResponse>(req, "OfflineInstance");
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="OfflineInstanceRequest"/></param>
        /// <returns><see cref="OfflineInstanceResponse"/></returns>
        public OfflineInstanceResponse OfflineInstanceSync(OfflineInstanceRequest req)
        {
            return InternalRequestAsync<OfflineInstanceResponse>(req, "OfflineInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TDSQL-C for MySQL实例开通审计服务
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// TDSQL-C for MySQL实例开通审计服务
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OpenClusterPasswordComplexity）用于开启自定义密码复杂度功能
        /// </summary>
        /// <param name="req"><see cref="OpenClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="OpenClusterPasswordComplexityResponse"/></returns>
        public Task<OpenClusterPasswordComplexityResponse> OpenClusterPasswordComplexity(OpenClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<OpenClusterPasswordComplexityResponse>(req, "OpenClusterPasswordComplexity");
        }

        /// <summary>
        /// 本接口（OpenClusterPasswordComplexity）用于开启自定义密码复杂度功能
        /// </summary>
        /// <param name="req"><see cref="OpenClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="OpenClusterPasswordComplexityResponse"/></returns>
        public OpenClusterPasswordComplexityResponse OpenClusterPasswordComplexitySync(OpenClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<OpenClusterPasswordComplexityResponse>(req, "OpenClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启只读实例组接入
        /// </summary>
        /// <param name="req"><see cref="OpenClusterReadOnlyInstanceGroupAccessRequest"/></param>
        /// <returns><see cref="OpenClusterReadOnlyInstanceGroupAccessResponse"/></returns>
        public Task<OpenClusterReadOnlyInstanceGroupAccessResponse> OpenClusterReadOnlyInstanceGroupAccess(OpenClusterReadOnlyInstanceGroupAccessRequest req)
        {
            return InternalRequestAsync<OpenClusterReadOnlyInstanceGroupAccessResponse>(req, "OpenClusterReadOnlyInstanceGroupAccess");
        }

        /// <summary>
        /// 开启只读实例组接入
        /// </summary>
        /// <param name="req"><see cref="OpenClusterReadOnlyInstanceGroupAccessRequest"/></param>
        /// <returns><see cref="OpenClusterReadOnlyInstanceGroupAccessResponse"/></returns>
        public OpenClusterReadOnlyInstanceGroupAccessResponse OpenClusterReadOnlyInstanceGroupAccessSync(OpenClusterReadOnlyInstanceGroupAccessRequest req)
        {
            return InternalRequestAsync<OpenClusterReadOnlyInstanceGroupAccessResponse>(req, "OpenClusterReadOnlyInstanceGroupAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通只读实例独有访问接入组
        /// </summary>
        /// <param name="req"><see cref="OpenReadOnlyInstanceExclusiveAccessRequest"/></param>
        /// <returns><see cref="OpenReadOnlyInstanceExclusiveAccessResponse"/></returns>
        public Task<OpenReadOnlyInstanceExclusiveAccessResponse> OpenReadOnlyInstanceExclusiveAccess(OpenReadOnlyInstanceExclusiveAccessRequest req)
        {
            return InternalRequestAsync<OpenReadOnlyInstanceExclusiveAccessResponse>(req, "OpenReadOnlyInstanceExclusiveAccess");
        }

        /// <summary>
        /// 开通只读实例独有访问接入组
        /// </summary>
        /// <param name="req"><see cref="OpenReadOnlyInstanceExclusiveAccessRequest"/></param>
        /// <returns><see cref="OpenReadOnlyInstanceExclusiveAccessResponse"/></returns>
        public OpenReadOnlyInstanceExclusiveAccessResponse OpenReadOnlyInstanceExclusiveAccessSync(OpenReadOnlyInstanceExclusiveAccessRequest req)
        {
            return InternalRequestAsync<OpenReadOnlyInstanceExclusiveAccessResponse>(req, "OpenReadOnlyInstanceExclusiveAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OpenWan）用于开通外网
        /// </summary>
        /// <param name="req"><see cref="OpenWanRequest"/></param>
        /// <returns><see cref="OpenWanResponse"/></returns>
        public Task<OpenWanResponse> OpenWan(OpenWanRequest req)
        {
            return InternalRequestAsync<OpenWanResponse>(req, "OpenWan");
        }

        /// <summary>
        /// 本接口（OpenWan）用于开通外网
        /// </summary>
        /// <param name="req"><see cref="OpenWanRequest"/></param>
        /// <returns><see cref="OpenWanResponse"/></returns>
        public OpenWanResponse OpenWanSync(OpenWanRequest req)
        {
            return InternalRequestAsync<OpenWanResponse>(req, "OpenWan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停serverless集群
        /// </summary>
        /// <param name="req"><see cref="PauseServerlessRequest"/></param>
        /// <returns><see cref="PauseServerlessResponse"/></returns>
        public Task<PauseServerlessResponse> PauseServerless(PauseServerlessRequest req)
        {
            return InternalRequestAsync<PauseServerlessResponse>(req, "PauseServerless");
        }

        /// <summary>
        /// 暂停serverless集群
        /// </summary>
        /// <param name="req"><see cref="PauseServerlessRequest"/></param>
        /// <returns><see cref="PauseServerlessResponse"/></returns>
        public PauseServerlessResponse PauseServerlessSync(PauseServerlessRequest req)
        {
            return InternalRequestAsync<PauseServerlessResponse>(req, "PauseServerless")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 退款资源包
        /// </summary>
        /// <param name="req"><see cref="RefundResourcePackageRequest"/></param>
        /// <returns><see cref="RefundResourcePackageResponse"/></returns>
        public Task<RefundResourcePackageResponse> RefundResourcePackage(RefundResourcePackageRequest req)
        {
            return InternalRequestAsync<RefundResourcePackageResponse>(req, "RefundResourcePackage");
        }

        /// <summary>
        /// 退款资源包
        /// </summary>
        /// <param name="req"><see cref="RefundResourcePackageRequest"/></param>
        /// <returns><see cref="RefundResourcePackageResponse"/></returns>
        public RefundResourcePackageResponse RefundResourcePackageSync(RefundResourcePackageRequest req)
        {
            return InternalRequestAsync<RefundResourcePackageResponse>(req, "RefundResourcePackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 负载均衡数据库代理
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public Task<ReloadBalanceProxyNodeResponse> ReloadBalanceProxyNode(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode");
        }

        /// <summary>
        /// 负载均衡数据库代理
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public ReloadBalanceProxyNodeResponse ReloadBalanceProxyNodeSync(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭多可用区部署
        /// </summary>
        /// <param name="req"><see cref="RemoveClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="RemoveClusterSlaveZoneResponse"/></returns>
        public Task<RemoveClusterSlaveZoneResponse> RemoveClusterSlaveZone(RemoveClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<RemoveClusterSlaveZoneResponse>(req, "RemoveClusterSlaveZone");
        }

        /// <summary>
        /// 关闭多可用区部署
        /// </summary>
        /// <param name="req"><see cref="RemoveClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="RemoveClusterSlaveZoneResponse"/></returns>
        public RemoveClusterSlaveZoneResponse RemoveClusterSlaveZoneSync(RemoveClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<RemoveClusterSlaveZoneResponse>(req, "RemoveClusterSlaveZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费集群
        /// </summary>
        /// <param name="req"><see cref="RenewClustersRequest"/></param>
        /// <returns><see cref="RenewClustersResponse"/></returns>
        public Task<RenewClustersResponse> RenewClusters(RenewClustersRequest req)
        {
            return InternalRequestAsync<RenewClustersResponse>(req, "RenewClusters");
        }

        /// <summary>
        /// 续费集群
        /// </summary>
        /// <param name="req"><see cref="RenewClustersRequest"/></param>
        /// <returns><see cref="RenewClustersResponse"/></returns>
        public RenewClustersResponse RenewClustersSync(RenewClustersRequest req)
        {
            return InternalRequestAsync<RenewClustersResponse>(req, "RenewClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResetAccountPassword)用于修改数据库账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// 本接口(ResetAccountPassword)用于修改数据库账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启实例
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance");
        }

        /// <summary>
        /// 重启实例
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复serverless集群
        /// </summary>
        /// <param name="req"><see cref="ResumeServerlessRequest"/></param>
        /// <returns><see cref="ResumeServerlessResponse"/></returns>
        public Task<ResumeServerlessResponse> ResumeServerless(ResumeServerlessRequest req)
        {
            return InternalRequestAsync<ResumeServerlessResponse>(req, "ResumeServerless");
        }

        /// <summary>
        /// 恢复serverless集群
        /// </summary>
        /// <param name="req"><see cref="ResumeServerlessRequest"/></param>
        /// <returns><see cref="ResumeServerlessResponse"/></returns>
        public ResumeServerlessResponse ResumeServerlessSync(ResumeServerlessRequest req)
        {
            return InternalRequestAsync<ResumeServerlessResponse>(req, "ResumeServerless")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量回收账号权限
        /// </summary>
        /// <param name="req"><see cref="RevokeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="RevokeAccountPrivilegesResponse"/></returns>
        public Task<RevokeAccountPrivilegesResponse> RevokeAccountPrivileges(RevokeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<RevokeAccountPrivilegesResponse>(req, "RevokeAccountPrivileges");
        }

        /// <summary>
        /// 批量回收账号权限
        /// </summary>
        /// <param name="req"><see cref="RevokeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="RevokeAccountPrivilegesResponse"/></returns>
        public RevokeAccountPrivilegesResponse RevokeAccountPrivilegesSync(RevokeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<RevokeAccountPrivilegesResponse>(req, "RevokeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RollBackCluster）用于集群回档
        /// </summary>
        /// <param name="req"><see cref="RollBackClusterRequest"/></param>
        /// <returns><see cref="RollBackClusterResponse"/></returns>
        public Task<RollBackClusterResponse> RollBackCluster(RollBackClusterRequest req)
        {
            return InternalRequestAsync<RollBackClusterResponse>(req, "RollBackCluster");
        }

        /// <summary>
        /// 本接口（RollBackCluster）用于集群回档
        /// </summary>
        /// <param name="req"><see cref="RollBackClusterRequest"/></param>
        /// <returns><see cref="RollBackClusterResponse"/></returns>
        public RollBackClusterResponse RollBackClusterSync(RollBackClusterRequest req)
        {
            return InternalRequestAsync<RollBackClusterResponse>(req, "RollBackCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回档到新集群
        /// </summary>
        /// <param name="req"><see cref="RollbackToNewClusterRequest"/></param>
        /// <returns><see cref="RollbackToNewClusterResponse"/></returns>
        public Task<RollbackToNewClusterResponse> RollbackToNewCluster(RollbackToNewClusterRequest req)
        {
            return InternalRequestAsync<RollbackToNewClusterResponse>(req, "RollbackToNewCluster");
        }

        /// <summary>
        /// 回档到新集群
        /// </summary>
        /// <param name="req"><see cref="RollbackToNewClusterRequest"/></param>
        /// <returns><see cref="RollbackToNewClusterResponse"/></returns>
        public RollbackToNewClusterResponse RollbackToNewClusterSync(RollbackToNewClusterRequest req)
        {
            return InternalRequestAsync<RollbackToNewClusterResponse>(req, "RollbackToNewCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SearchClusterDatabases)搜索集群数据库列表
        /// </summary>
        /// <param name="req"><see cref="SearchClusterDatabasesRequest"/></param>
        /// <returns><see cref="SearchClusterDatabasesResponse"/></returns>
        public Task<SearchClusterDatabasesResponse> SearchClusterDatabases(SearchClusterDatabasesRequest req)
        {
            return InternalRequestAsync<SearchClusterDatabasesResponse>(req, "SearchClusterDatabases");
        }

        /// <summary>
        /// 本接口(SearchClusterDatabases)搜索集群数据库列表
        /// </summary>
        /// <param name="req"><see cref="SearchClusterDatabasesRequest"/></param>
        /// <returns><see cref="SearchClusterDatabasesResponse"/></returns>
        public SearchClusterDatabasesResponse SearchClusterDatabasesSync(SearchClusterDatabasesRequest req)
        {
            return InternalRequestAsync<SearchClusterDatabasesResponse>(req, "SearchClusterDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SearchClusterTables)搜索集群数据表列表
        /// </summary>
        /// <param name="req"><see cref="SearchClusterTablesRequest"/></param>
        /// <returns><see cref="SearchClusterTablesResponse"/></returns>
        public Task<SearchClusterTablesResponse> SearchClusterTables(SearchClusterTablesRequest req)
        {
            return InternalRequestAsync<SearchClusterTablesResponse>(req, "SearchClusterTables");
        }

        /// <summary>
        /// 本接口(SearchClusterTables)搜索集群数据表列表
        /// </summary>
        /// <param name="req"><see cref="SearchClusterTablesRequest"/></param>
        /// <returns><see cref="SearchClusterTablesResponse"/></returns>
        public SearchClusterTablesResponse SearchClusterTablesSync(SearchClusterTablesRequest req)
        {
            return InternalRequestAsync<SearchClusterTablesResponse>(req, "SearchClusterTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SetRenewFlag设置实例的自动续费功能
        /// </summary>
        /// <param name="req"><see cref="SetRenewFlagRequest"/></param>
        /// <returns><see cref="SetRenewFlagResponse"/></returns>
        public Task<SetRenewFlagResponse> SetRenewFlag(SetRenewFlagRequest req)
        {
            return InternalRequestAsync<SetRenewFlagResponse>(req, "SetRenewFlag");
        }

        /// <summary>
        /// SetRenewFlag设置实例的自动续费功能
        /// </summary>
        /// <param name="req"><see cref="SetRenewFlagRequest"/></param>
        /// <returns><see cref="SetRenewFlagResponse"/></returns>
        public SetRenewFlagResponse SetRenewFlagSync(SetRenewFlagRequest req)
        {
            return InternalRequestAsync<SetRenewFlagResponse>(req, "SetRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启日志投递
        /// </summary>
        /// <param name="req"><see cref="StartCLSDeliveryRequest"/></param>
        /// <returns><see cref="StartCLSDeliveryResponse"/></returns>
        public Task<StartCLSDeliveryResponse> StartCLSDelivery(StartCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StartCLSDeliveryResponse>(req, "StartCLSDelivery");
        }

        /// <summary>
        /// 开启日志投递
        /// </summary>
        /// <param name="req"><see cref="StartCLSDeliveryRequest"/></param>
        /// <returns><see cref="StartCLSDeliveryResponse"/></returns>
        public StartCLSDeliveryResponse StartCLSDeliverySync(StartCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StartCLSDeliveryResponse>(req, "StartCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止日志投递
        /// </summary>
        /// <param name="req"><see cref="StopCLSDeliveryRequest"/></param>
        /// <returns><see cref="StopCLSDeliveryResponse"/></returns>
        public Task<StopCLSDeliveryResponse> StopCLSDelivery(StopCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StopCLSDeliveryResponse>(req, "StopCLSDelivery");
        }

        /// <summary>
        /// 停止日志投递
        /// </summary>
        /// <param name="req"><see cref="StopCLSDeliveryRequest"/></param>
        /// <returns><see cref="StopCLSDeliveryResponse"/></returns>
        public StopCLSDeliveryResponse StopCLSDeliverySync(StopCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StopCLSDeliveryResponse>(req, "StopCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更换集群vpc
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterVpcRequest"/></param>
        /// <returns><see cref="SwitchClusterVpcResponse"/></returns>
        public Task<SwitchClusterVpcResponse> SwitchClusterVpc(SwitchClusterVpcRequest req)
        {
            return InternalRequestAsync<SwitchClusterVpcResponse>(req, "SwitchClusterVpc");
        }

        /// <summary>
        /// 更换集群vpc
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterVpcRequest"/></param>
        /// <returns><see cref="SwitchClusterVpcResponse"/></returns>
        public SwitchClusterVpcResponse SwitchClusterVpcSync(SwitchClusterVpcRequest req)
        {
            return InternalRequestAsync<SwitchClusterVpcResponse>(req, "SwitchClusterVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 主备可用区切换
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterZoneRequest"/></param>
        /// <returns><see cref="SwitchClusterZoneResponse"/></returns>
        public Task<SwitchClusterZoneResponse> SwitchClusterZone(SwitchClusterZoneRequest req)
        {
            return InternalRequestAsync<SwitchClusterZoneResponse>(req, "SwitchClusterZone");
        }

        /// <summary>
        /// 主备可用区切换
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterZoneRequest"/></param>
        /// <returns><see cref="SwitchClusterZoneResponse"/></returns>
        public SwitchClusterZoneResponse SwitchClusterZoneSync(SwitchClusterZoneRequest req)
        {
            return InternalRequestAsync<SwitchClusterZoneResponse>(req, "SwitchClusterZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SwitchProxyVpc)更换数据库代理vpc
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyVpcRequest"/></param>
        /// <returns><see cref="SwitchProxyVpcResponse"/></returns>
        public Task<SwitchProxyVpcResponse> SwitchProxyVpc(SwitchProxyVpcRequest req)
        {
            return InternalRequestAsync<SwitchProxyVpcResponse>(req, "SwitchProxyVpc");
        }

        /// <summary>
        /// 本接口(SwitchProxyVpc)更换数据库代理vpc
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyVpcRequest"/></param>
        /// <returns><see cref="SwitchProxyVpcResponse"/></returns>
        public SwitchProxyVpcResponse SwitchProxyVpcSync(SwitchProxyVpcRequest req)
        {
            return InternalRequestAsync<SwitchProxyVpcResponse>(req, "SwitchProxyVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// cynos解绑资源包
        /// </summary>
        /// <param name="req"><see cref="UnbindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="UnbindClusterResourcePackagesResponse"/></returns>
        public Task<UnbindClusterResourcePackagesResponse> UnbindClusterResourcePackages(UnbindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<UnbindClusterResourcePackagesResponse>(req, "UnbindClusterResourcePackages");
        }

        /// <summary>
        /// cynos解绑资源包
        /// </summary>
        /// <param name="req"><see cref="UnbindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="UnbindClusterResourcePackagesResponse"/></returns>
        public UnbindClusterResourcePackagesResponse UnbindClusterResourcePackagesSync(UnbindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<UnbindClusterResourcePackagesResponse>(req, "UnbindClusterResourcePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新内核小版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterVersionRequest"/></param>
        /// <returns><see cref="UpgradeClusterVersionResponse"/></returns>
        public Task<UpgradeClusterVersionResponse> UpgradeClusterVersion(UpgradeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpgradeClusterVersionResponse>(req, "UpgradeClusterVersion");
        }

        /// <summary>
        /// 更新内核小版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterVersionRequest"/></param>
        /// <returns><see cref="UpgradeClusterVersionResponse"/></returns>
        public UpgradeClusterVersionResponse UpgradeClusterVersionSync(UpgradeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpgradeClusterVersionResponse>(req, "UpgradeClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例变配
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// 实例变配
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级数据库代理配置
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyRequest"/></param>
        /// <returns><see cref="UpgradeProxyResponse"/></returns>
        public Task<UpgradeProxyResponse> UpgradeProxy(UpgradeProxyRequest req)
        {
            return InternalRequestAsync<UpgradeProxyResponse>(req, "UpgradeProxy");
        }

        /// <summary>
        /// 升级数据库代理配置
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyRequest"/></param>
        /// <returns><see cref="UpgradeProxyResponse"/></returns>
        public UpgradeProxyResponse UpgradeProxySync(UpgradeProxyRequest req)
        {
            return InternalRequestAsync<UpgradeProxyResponse>(req, "UpgradeProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级数据库代理版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public Task<UpgradeProxyVersionResponse> UpgradeProxyVersion(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion");
        }

        /// <summary>
        /// 升级数据库代理版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public UpgradeProxyVersionResponse UpgradeProxyVersionSync(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
