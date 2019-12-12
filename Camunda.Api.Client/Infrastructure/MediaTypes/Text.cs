using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Infrastructure.MediaTypes
{
        /// <summary>
        ///   Encapsulates the media subtypes registered under the text type.
        /// </summary>
        public class Text
        {
            /// <summary>text/1d-interleaved-parityfec</summary>
            public const string _1dInterleavedParityfec = "text/1d-interleaved-parityfec";
            /// <summary>text/cache-manifest</summary>
            public const string CacheManifest = "text/cache-manifest";
            /// <summary>text/calendar</summary>
            public const string Calendar = "text/calendar";
            /// <summary>text/css</summary>
            public const string Css = "text/css";
            /// <summary>text/csv</summary>
            public const string Csv = "text/csv";
            /// <summary>text/directory</summary>
            [Obsolete("DEPRECATED by RFC6350")]
            public const string Directory = "text/directory";
            /// <summary>text/dns</summary>
            public const string Dns = "text/dns";
            /// <summary>text/ecmascript</summary>
            [Obsolete("OBSOLETED in favor of application/ecmascript")]
            public const string Ecmascript = "text/ecmascript";
            /// <summary>text/encaprtp</summary>
            public const string Encaprtp = "text/encaprtp";
            /// <summary>text/enriched</summary>
            public const string Enriched = "text/enriched";
            /// <summary>text/example</summary>
            public const string Example = "text/example";
            /// <summary>text/fwdred</summary>
            public const string Fwdred = "text/fwdred";
            /// <summary>text/grammar-ref-list</summary>
            public const string GrammarRefList = "text/grammar-ref-list";
            /// <summary>text/html</summary>
            /// <remarks>This is that web stuff.</remarks>
            public const string Html = "text/html";
            /// <summary>text/javascript</summary>
            [Obsolete("OBSOLETED in favor of application/javascript")]
            public const string Javascript = "text/javascript";
            /// <summary>text/jcr-cnd</summary>
            public const string JcrCnd = "text/jcr-cnd";
            /// <summary>text/mizar</summary>
            public const string Mizar = "text/mizar";
            /// <summary>text/n3</summary>
            public const string N3 = "text/n3";
            /// <summary>text/parameters</summary>
            public const string Parameters = "text/parameters";
            /// <summary>text/parityfec</summary>
            public const string Parityfec = "text/parityfec";
            /// <summary>text/plain</summary>
            public const string Plain = "text/plain";
            /// <summary>text/provenance-notation</summary>
            public const string ProvenanceNotation = "text/provenance-notation";
            /// <summary>text/prs.fallenstein.rst</summary>
            public const string PrsFallensteinRst = "text/prs.fallenstein.rst";
            /// <summary>text/prs.lines.tag</summary>
            public const string PrsLinesTag = "text/prs.lines.tag";
            /// <summary>text/raptorfec</summary>
            public const string Raptorfec = "text/raptorfec";
            /// <summary>text/RED</summary>
            public const string Red = "text/RED";
            /// <summary>text/rfc822-headers</summary>
            public const string Rfc822Headers = "text/rfc822-headers";
            /// <summary>text/richtext</summary>
            public const string Richtext = "text/richtext";
            /// <summary>text/rtf</summary>
            public const string Rtf = "text/rtf";
            /// <summary>text/rtp-enc-aescm128</summary>
            public const string RtpEncAescm128 = "text/rtp-enc-aescm128";
            /// <summary>text/rtploopback</summary>
            public const string Rtploopback = "text/rtploopback";
            /// <summary>text/rtx</summary>
            public const string Rtx = "text/rtx";
            /// <summary>text/sgml</summary>
            public const string Sgml = "text/sgml";
            /// <summary>text/t140</summary>
            public const string T140 = "text/t140";
            /// <summary>text/tab-separated-values</summary>
            public const string TabSeparatedValues = "text/tab-separated-values";
            /// <summary>text/troff</summary>
            public const string Troff = "text/troff";
            /// <summary>text/turtle</summary>
            public const string Turtle = "text/turtle";
            /// <summary>text/ulpfec</summary>
            public const string Ulpfec = "text/ulpfec";
            /// <summary>text/uri-list</summary>
            public const string UriList = "text/uri-list";
            /// <summary>text/vcard</summary>
            public const string Vcard = "text/vcard";
            /// <summary>text/vnd.a</summary>
            public const string VndA = "text/vnd.a";
            /// <summary>text/vnd.abc</summary>
            public const string VndAbc = "text/vnd.abc";
            /// <summary>text/vnd.curl</summary>
            public const string VndCurl = "text/vnd.curl";
            /// <summary>text/vnd.debian.copyright</summary>
            public const string VndDebianCopyright = "text/vnd.debian.copyright";
            /// <summary>text/vnd.DMClientScript</summary>
            public const string VndDmclientscript = "text/vnd.DMClientScript";
            /// <summary>text/vnd.dvb.subtitle</summary>
            public const string VndDvbSubtitle = "text/vnd.dvb.subtitle";
            /// <summary>text/vnd.esmertec.theme-descriptor</summary>
            public const string VndEsmertecThemeDescriptor = "text/vnd.esmertec.theme-descriptor";
            /// <summary>text/vnd.fly</summary>
            public const string VndFly = "text/vnd.fly";
            /// <summary>text/vnd.fmi.flexstor</summary>
            public const string VndFmiFlexstor = "text/vnd.fmi.flexstor";
            /// <summary>text/vnd.graphviz</summary>
            public const string VndGraphviz = "text/vnd.graphviz";
            /// <summary>text/vnd.in3d.3dml</summary>
            public const string VndIn3d3dml = "text/vnd.in3d.3dml";
            /// <summary>text/vnd.in3d.spot</summary>
            public const string VndIn3dSpot = "text/vnd.in3d.spot";
            /// <summary>text/vnd.IPTC.NewsML</summary>
            public const string VndIptcNewsml = "text/vnd.IPTC.NewsML";
            /// <summary>text/vnd.IPTC.NITF</summary>
            public const string VndIptcNitf = "text/vnd.IPTC.NITF";
            /// <summary>text/vnd.latex-z</summary>
            public const string VndLatexZ = "text/vnd.latex-z";
            /// <summary>text/vnd.motorola.reflex</summary>
            public const string VndMotorolaReflex = "text/vnd.motorola.reflex";
            /// <summary>text/vnd.ms-mediapackage</summary>
            public const string VndMsMediapackage = "text/vnd.ms-mediapackage";
            /// <summary>text/vnd.net2phone.commcenter.command</summary>
            public const string VndNet2phoneCommcenterCommand = "text/vnd.net2phone.commcenter.command";
            /// <summary>text/vnd.radisys.msml-basic-layout</summary>
            public const string VndRadisysMsmlBasicLayout = "text/vnd.radisys.msml-basic-layout";
            /// <summary>text/vnd.si.uricatalogue</summary>
            [Obsolete("OBSOLETED by request")]
            public const string VndSiUricatalogue = "text/vnd.si.uricatalogue";
            /// <summary>text/vnd.sun.j2me.app-descriptor</summary>
            public const string VndSunJ2meAppDescriptor = "text/vnd.sun.j2me.app-descriptor";
            /// <summary>text/vnd.trolltech.linguist</summary>
            public const string VndTrolltechLinguist = "text/vnd.trolltech.linguist";
            /// <summary>text/vnd.wap.si</summary>
            public const string VndWapSi = "text/vnd.wap.si";
            /// <summary>text/vnd.wap.sl</summary>
            public const string VndWapSl = "text/vnd.wap.sl";
            /// <summary>text/vnd.wap.wml</summary>
            public const string VndWapWml = "text/vnd.wap.wml";
            /// <summary>text/vnd.wap.wmlscript</summary>
            public const string VndWapWmlscript = "text/vnd.wap.wmlscript";
            /// <summary>text/xml</summary>
            public const string Xml = "text/xml";
            /// <summary>text/xml-external-parsed-entity</summary>
            public const string XmlExternalParsedEntity = "text/xml-external-parsed-entity";
        }
}
