using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using ZCSAPI.BLL;
using ZCSAPI.BLL.Message;
using ZCSAPI.BLL.ViewModels;
using ZCSAPI.Common.DEncrypt;
using ZCSAPI.Common.WebUtility;

namespace ZCSAPI.App_Start
{
    public class BasicAuthorizeAttribute : AuthorizeAttribute
    {
        IPrincipal UserIdentity;
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            UserIdentity = actionContext.ControllerContext.RequestContext.Principal;
            if (actionContext.Request.Headers.Authorization != null)
            {
                var auth = actionContext.Request.Headers.Authorization;
                string authHeader = actionContext.Request.Headers.Authorization.Parameter;

                if (auth == null || string.IsNullOrEmpty(authHeader))
                {
                    HandleUnauthorizedRequest(actionContext);
                    return;
                }

                //if ((authHeader.Length % 4) != 0 && !Regex.IsMatch(authHeader, "^[A-Z0-9/+=]*$", RegexOptions.IgnoreCase))
                //{
                //    HandleUnauthorizedRequest(actionContext);
                //    return;
                //}

                //string userInfo = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader));
                string userInfo = authHeader;

                if (!userInfo.Contains(":"))
                {
                    HandleUnauthorizedRequest(actionContext);
                    return;
                }

                var tokens = userInfo.Split(':');

                if (tokens.Length < 2)
                {
                    HandleUnauthorizedRequest(actionContext);
                    return;
                }

                if (auth.Scheme == "Basic")
                {
                    LoginNameLogin(actionContext, userInfo);
                    return;
                }

                HandleUnauthorizedRequest(actionContext);
            }
            else
            {
                HandleUnauthorizedRequest(actionContext);
            }
        }

        /// <summary>
        /// 用户名登录
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="userInfo"></param>
        private void LoginNameLogin(System.Web.Http.Controllers.HttpActionContext actionContext, string userInfo)
        {
            var tokens = userInfo.Split(':');
            var loginCode = tokens[0].Trim();
            var password = tokens[1].Trim();

            var obj = CacheHelper.GetCache("bu_" + loginCode);

            if (obj != null)
            {
                var cacheUser = (string)obj;
                var passArr = cacheUser.Split(':');
                var calcuPassword = DEncrypt.CalculatePassword(password, passArr[0]);

                if (calcuPassword == passArr[1])
                {
                    IsAuthorized(actionContext);
                    return;
                }
                CacheHelper.RemoveAllCache("bu_" + loginCode);
            }

            UserRequest request = new UserRequest(new UserView());
            request.Data.Code = loginCode;
            var user = LoginUser.GetUserByCode(request).Data;

            if (user == null)
            {
                HandleUnauthorizedRequest(actionContext);
                return;
            }

            var calculatedPassword = DEncrypt.CalculatePassword(password, user.PasswordSalt);

            if (calculatedPassword == user.Password)
            {
                IsAuthorized(actionContext);
                CacheHelper.SetCache("bu_" + loginCode, user.PasswordSalt + ":" + user.Password, TimeSpan.FromSeconds(20));
                user = null;
            }
            else
            {
                HandleUnauthorizedRequest(actionContext);
            }

        }

        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var challengeMessage = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            challengeMessage.Headers.Add("WWW-Authenticate", "Basic");
            throw new System.Web.Http.HttpResponseException(challengeMessage);
        }
    }
}