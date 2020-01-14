using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Deployment
{
    public interface IDeploymentService
    {
        DeploymentResource this[string deploymentId] { get; }
        QueryResource<DeploymentQuery, DeploymentInfo> Query(DeploymentQuery query = null);

        /// <summary>
        /// Create a deployment.
        /// </summary>
        /// <remarks>
        /// Deployments can contain custom code in form of scripts or EL expressions to customize process behavior. 
        /// This may be abused for remote execution of arbitrary code. See the section on security considerations for custom code in the user guide for details.
        /// </remarks>
        /// <param name="deploymentName">The name for the deployment to be created.</param>
        /// <param name="resources">The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment.</param>
        /// <param name="changedOnly">A flag indicating whether the process engine should perform duplicate checking on a per-resource basis. If set to true, only those resources that have actually changed are deployed. Checks are made against resources included previous deployments of the same name and only against the latest versions of those resources. If set to true, the option duplicateFiltering is overridden and set to true.</param>
        /// <param name="deploymentSource">The source for the deployment to be created.</param>
        /// <param name="duplicateFiltering">A flag indicating whether the process engine should perform duplicate checking for the deployment or not. This allows you to check if a deployment with the same name and the same resouces already exists and if true, not create a new deployment but instead return the existing deployment. The default value is false.</param>
        /// <param name="tenantId">The tenant id for the deployment to be created.</param>
        Task<DeploymentInfo> Create(string deploymentName, bool duplicateFiltering, bool changedOnly, string deploymentSource, string tenantId = null,
            params ResourceDataContent[] resources);

        /// <summary>
        /// Create a deployment.
        /// </summary>
        /// <remarks>
        /// Deployments can contain custom code in form of scripts or EL expressions to customize process behavior. 
        /// This may be abused for remote execution of arbitrary code. See the section on security considerations for custom code in the user guide for details.
        /// </remarks>
        /// <param name="deploymentName">The name for the deployment to be created.</param>
        /// <param name="resources">The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment.</param>
        Task<DeploymentInfo> Create(string deploymentName, 
            params ResourceDataContent[] resources);
    }
}