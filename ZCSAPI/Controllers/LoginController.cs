using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZCSAPI.Common.DEncrypt;

namespace ZCSAPI.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public string Get(string userName, string passWord)
        {
            string modulus = @"+6X/O6SpJB8yg8ALmxbGC4vtGWsQCtOAB+IqlulD0LdiRlCOJBMZBTfr3
BWtnz6uFfbsNwBUVD/ruxlfNdgsIc+pdTToHvMQ+vnMR7z9B9fK4v/6ZY7glDPeAu4lMbNm0roVKGy3TgjxEm7AFe
1HecNs4xUbYsRvvl63GBfTAwE=";
            string exponent = "AQAB";
            string privateKey = @"BwIAAACkAABSU0EyAAQAAAEAAQABA9MXGLdevm/EYhsV42zDeUftFc
BuEvEITrdsKBW60mazMSXuAt4zlOCOZfr/4srXB/28R8z5+hDzHug0danPISzYNV8Zu+s/VFQAN+z2Fa4+n60V3Os
3BRkTJI5QRmK30EPpliriB4DTChBrGe2LC8YWmwvAgzIfJKmkO/+l++N3DFqkRpYfW1nYgdgdGcRNrChyn46PrItJn
MITaFV/ECwMgQUO9H0cHs4jj+392rkpK/o3UCTscJYnB5kXRP7L5v6jg3jWWrLwLU2TUQTZknaqO7QBjXTNtfS8aFT
FhYE0GOXRCSCoWLZdWX6ShD8NQUcHC/GNzEuywonBVV39ly8AEjvW6YoLLNYpkzPVFcAQlFPhzp4TZl4HOvhFEvEI
KPyxqa9VF98QoStZvst6uN0QEgde9onA/4x1aWekesv+cYYBWAN4nvriWCEVzzyASSKXGCGkv+hu7hElt9tjR/uOj
1Fv4bnarnTqz3m6RUVuH2S3wTORd2vLaQcXtxvTSx9Hqn+3Gw+eBbTcV5m2oH2aL2+1C/27tVSoJKAiRso1xWEXwEe
DEyn+pIujRFOTaj02DBvl6B1+oOYs0MV7TVZqwysngA8mzbgf2+Dees53MnH3V9InW5npX5QyKxm/GlOur2lioBRYD
J6ppPd8KMMJnBG/LXPkFIJ5rlN1aUKG0kcXkv/MX/7N5bwBsoejlQ/T4Ltcb1XcHl3+fl5uKcQmj09K3W2PW4VZSeQ
suIkMS9wywOgR3ZL+v+43hB0=";
            string user = String.Empty;
            RSACryption.EncryptText("zcs", modulus, exponent, out user);
            return user;
        }
    }
}
