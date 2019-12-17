using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Infrastructure.Iana.MediaTypes
{
        /// <summary>
        ///   Encapsulates the media subtypes registered under the message type.
        /// </summary>
        public class Message
        {
            /// <summary>message/CPIM</summary>
            public const string Cpim = "message/CPIM";
            /// <summary>message/delivery-status</summary>
            public const string DeliveryStatus = "message/delivery-status";
            /// <summary>message/disposition-notification</summary>
            public const string DispositionNotification = "message/disposition-notification";
            /// <summary>message/example</summary>
            public const string Example = "message/example";
            /// <summary>message/external-body</summary>
            public const string ExternalBody = "message/external-body";
            /// <summary>message/feedback-report</summary>
            public const string FeedbackReport = "message/feedback-report";
            /// <summary>message/global</summary>
            public const string Global = "message/global";
            /// <summary>message/global-delivery-status</summary>
            public const string GlobalDeliveryStatus = "message/global-delivery-status";
            /// <summary>message/global-disposition-notification</summary>
            public const string GlobalDispositionNotification = "message/global-disposition-notification";
            /// <summary>message/global-headers</summary>
            public const string GlobalHeaders = "message/global-headers";
            /// <summary>message/http</summary>
            public const string Http = "message/http";
            /// <summary>message/imdn+xml</summary>
            public const string ImdnXml = "message/imdn+xml";
            /// <summary>message/news</summary>
            [Obsolete("OBSOLETED by RFC5537")]
            public const string News = "message/news";
            /// <summary>message/partial</summary>
            public const string Partial = "message/partial";
            /// <summary>message/rfc822</summary>
            public const string Rfc822 = "message/rfc822";
            /// <summary>message/s-http</summary>
            public const string SHttp = "message/s-http";
            /// <summary>message/sip</summary>
            public const string Sip = "message/sip";
            /// <summary>message/sipfrag</summary>
            public const string Sipfrag = "message/sipfrag";
            /// <summary>message/tracking-status</summary>
            public const string TrackingStatus = "message/tracking-status";
            /// <summary>message/vnd.si.simp</summary>
            [Obsolete("OBSOLETED by request")]
            public const string VndSiSimp = "message/vnd.si.simp";
            /// <summary>message/vnd.wfa.wsc</summary>
            public const string VndWfaWsc = "message/vnd.wfa.wsc";
        }
}
