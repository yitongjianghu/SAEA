﻿/***************************************************************************** 
  ____    _    _____    _      ____             _        _   
 / ___|  / \  | ____|  / \    / ___|  ___   ___| | _____| |_ 
 \___ \ / _ \ |  _|   / _ \   \___ \ / _ \ / __| |/ / _ \ __|
  ___) / ___ \| |___ / ___ \   ___) | (_) | (__|   <  __/ |_ 
 |____/_/   \_\_____/_/   \_\ |____/ \___/ \___|_|\_\___|\__|
                                                             

*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 2.1.4
*机器名称：WENLI-PC
*公司名称：wenli
*命名空间：SAEA.Sockets.Interface
*文件名： IServerSokcet
*版本号： v4.5.6.7
*唯一标识：ef84e44b-6fa2-432e-90a2-003ebd059303
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/3/1 15:54:21
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/3/1 15:54:21
*修改人： yswenli
*版本号： v4.5.6.7
*描述：
*****************************************************************************/

using SAEA.Sockets.Handler;

namespace SAEA.Sockets.Interface
{
    public interface IServerSokcet
    {
        void Start(int backlog = 10 * 1000);

        void Stop();

        void Disconnecte(object obj);

        ISocketOption SocketOption { get; set; }

        event OnAcceptedHandler OnAccepted;

        event OnErrorHandler OnError;

        event OnReceiveHandler OnReceive;

        void Dispose();
    }
}
