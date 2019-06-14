﻿/****************************************************************************
*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：yswenli
*命名空间：SAEA.Http.Model
*文件名： RequestHeaderType
*版本号： v4.5.6.7
*唯一标识：a303db7d-f83c-4c49-9804-032ec2236232
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/4/10 13:58:08
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/4/10 13:58:08
*修改人： yswenli
*版本号： v4.5.6.7
*描述：
*
*****************************************************************************/
using System.ComponentModel;

namespace SAEA.Http.Model
{
    public enum RequestHeaderType
    {
        /// <summary>
        /// Cache-Control 标头，指定请求/响应链上所有缓存控制机制必须服从的指令。
        /// </summary>
        [Description("Cache-Control")]
        CacheControl = 0,

        /// <summary>
        /// Connection 标头，指定特定连接需要的选项。
        /// </summary>
        [Description("Connection")]
        Connection = 1,

        /// <summary>
        /// Date 标头，指定开始创建请求的日期和时间。
        /// </summary>
        [Description("Date")]
        Date = 2,

        /// <summary>
        /// Keep-Alive 标头，指定用以维护持久性连接的参数。
        /// </summary>
        [Description("Keep-Alive")]
        KeepAlive = 3,

        /// <summary>
        /// Pragma 标头，指定可应用于请求/响应链上的任何代理的特定于实现的指令。
        /// </summary>
        [Description("Pragma")]
        Pragma = 4,

        /// <summary>
        /// Trailer 标头，指定标头字段显示在以 chunked 传输编码方式编码的消息的尾部。
        /// </summary>
        [Description("Trailer")]
        Trailer = 5,

        /// <summary>
        /// Transfer-Encoding 标头，指定对消息正文应用的转换的类型（如果有）。
        /// </summary>
        [Description("Transfer-Encoding")]
        TransferEncoding = 6,

        /// <summary>
        /// Upgrade 标头，指定客户端支持的附加通信协议。
        /// </summary>
        [Description("Upgrade")]
        Upgrade = 7,

        /// <summary>
        /// Via 标头，指定网关和代理程序要使用的中间协议。
        /// </summary>
        [Description("Via")]
        Via = 8,

        /// <summary>
        /// Warning 标头，指定关于可能未在消息中反映的消息的状态或转换的附加信息。
        /// </summary>
        [Description("Warning")]
        Warning = 9,

        /// <summary>
        /// Allow 标头，指定支持的 HTTP 方法集。
        /// </summary>
        [Description("Allow")]
        Allow = 10,

        /// <summary>
        /// Content-Length 标头，指定伴随正文数据的长度（以字节为单位）。
        /// </summary>
        [Description("Content-Length")]
        ContentLength = 11,

        /// <summary>
        /// Content-Type 标头，指定伴随正文数据的 MIME 类型。
        /// </summary>
        [Description("Content-Type")]
        ContentType = 12,

        /// <summary>
        /// Content-Encoding 标头，指定已应用于伴随正文数据的编码。
        /// </summary>
        [Description("Content-Encoding")]
        ContentEncoding = 13,

        /// <summary>
        /// Content-Langauge 标头，指定伴随正文数据的自然语言。
        /// </summary>
        [Description("Content-Langauge")]
        ContentLanguage = 14,

        /// <summary>
        /// Content-Location 标头，指定可从其中获得伴随正文的 URI。
        /// </summary>
        [Description("Content-Location")]
        ContentLocation = 15,

        /// <summary>
        /// Content-MD5 标头，指定伴随正文数据的 MD5 摘要，用于提供端到端消息完整性检查。
        /// </summary>
        [Description("Content-MD5")]
        ContentMd5 = 16,

        /// <summary>
        /// Content-Range 标头，指定在完整正文中应用伴随部分正文数据的位置。
        /// </summary>
        [Description("Content-Range")]
        ContentRange = 17,

        /// <summary>
        /// Expires 标头，指定日期和时间，在此之后伴随的正文数据应视为陈旧的。
        /// </summary>
        [Description("Expires")]
        Expires = 18,

        /// <summary>
        /// Last-Modified 标头，指定上次修改伴随的正文数据的日期和时间。
        /// </summary>
        [Description("Last-Modified")]
        LastModified = 19,

        /// <summary>
        /// Accept 标头，指定响应可接受的 MIME 类型。
        /// </summary>
        [Description("Accept")]
        Accept = 20,

        /// <summary>
        /// Accept-Charset 标头，指定响应可接受的字符集。
        /// </summary>
        [Description("Accept-Charset")]
        AcceptCharset = 21,

        /// <summary>
        /// Accept-Encoding 标头，指定响应可接受的内容编码。
        /// </summary>
        [Description("Accept-Encoding")]
        AcceptEncoding = 22,

        /// <summary>
        /// Accept-Langauge 标头，指定响应首选的自然语言。
        /// </summary>
        [Description("Accept-Langauge")]
        AcceptLanguage = 23,

        /// <summary>
        /// Authorization 标头，指定客户端为向服务器验证自身身份而出示的凭据。
        /// </summary>
        [Description("Authorization")]
        Authorization = 24,

        /// <summary>
        /// Cookie 标头，指定向服务器提供的 Cookie 数据。
        /// </summary>
        [Description("Cookie")]
        Cookie = 25,

        /// <summary>
        /// Expect 标头，指定客户端要求的特定服务器行为。
        /// </summary>
        [Description("Expect")]
        Expect = 26,

        /// <summary>
        /// From 标头，指定控制请求用户代理的用户的 Internet 电子邮件地址。
        /// </summary>
        [Description("From")]
        From = 27,

        /// <summary>
        /// Host 标头，指定所请求资源的主机名和端口号。
        /// </summary>
        [Description("Host")]
        Host = 28,

        /// <summary>
        /// If-Match 标头，指定仅当客户端的指示资源的缓存副本是最新的时，才执行请求的操作。
        /// </summary>
        [Description("If-Match")]
        IfMatch = 29,

        /// <summary>
        /// If-Modified-Since 标头，指定仅当自指示的数据和时间之后修改了请求的资源时，才执行请求的操作。
        /// </summary>
        [Description("If-Modified-Since")]
        IfModifiedSince = 30,

        /// <summary>
        /// If-None-Match 标头，指定仅当客户端的指示资源的缓存副本都不是最新的时，才执行请求的操作。
        /// </summary>
        [Description("If-None-Match")]
        IfNoneMatch = 31,

        /// <summary>
        /// If-Range 标头，指定如果客户端的缓存副本是最新的，仅发送指定范围的请求资源。
        /// </summary>
        [Description("If-Range")]
        IfRange = 32,

        /// <summary>
        /// If-Unmodified-Since 标头，指定仅当自指示的日期和时间之后修改了请求的资源时，才执行请求的操作。
        /// </summary>
        [Description("If-Unmodified-Since")]
        IfUnmodifiedSince = 33,

        /// <summary>
        /// Max-Forwards 标头，指定一个整数，表示此请求还可转发的次数。
        /// </summary>
        [Description("Max-Forwards")]
        MaxForwards = 34,

        /// <summary>
        /// Proxy-Authorization 标头，指定客户端为向代理验证自身身份而出示的凭据。
        /// </summary>
        [Description("Proxy-Authorization")]
        ProxyAuthorization = 35,

        /// <summary>
        /// Referer 标头，指定从中获得请求 URI 的资源的 URI。
        /// </summary>
        [Description("Referer")]
        Referer = 36,

        /// <summary>
        /// Range 标头，指定代替整个响应返回的客户端请求的响应的子范围。
        /// </summary>
        [Description("Range")]
        Range = 37,

        /// <summary>
        /// TE 标头，指定响应可接受的传输编码方式。
        /// </summary>
        [Description("TE")]
        Te = 38,

        /// <summary>
        /// Translate 标头，与 WebDAV 功能一起使用的 HTTP 规范的 Microsoft 扩展。
        /// </summary>
        [Description("Translate")]
        Translate = 39,

        /// <summary>
        /// User-Agent 标头，指定有关客户端代理的信息。
        /// </summary>
        [Description("User-Agent")]
        UserAgent = 40,

    }
}
