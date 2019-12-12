namespace Camunda.Api.Client.ServiceEndpoints.User
{
    internal class UserCredentialsInfo
    {
        /// <summary>
        /// The user's new password.
        /// </summary>
        public string Password;
        /// <summary>
        /// The password of the current authenticated user who changes the password of the user.
        /// </summary>
        public string AuthenticatedUserPassword;
    }
}
