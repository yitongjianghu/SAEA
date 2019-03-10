﻿/****************************************************************************
*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：yswenli
*命名空间：SAEA.MVC
*文件名： SAEAMvcApplicationConfigBuilder
*版本号： v4.2.1.6
*唯一标识：1ed5d381-d7ce-4ea3-b8b5-c32f581ad49f
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/4/12 10:55:31
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/4/12 10:55:31
*修改人： yswenli
*版本号： v4.2.1.6
*描述：
*
*****************************************************************************/
using SAEA.Common;

namespace SAEA.MVC
{
    public static class SAEAMvcApplicationConfigBuilder
    {
        static string _FilePath = PathHelper.GetFullName("SAEAMvcApplicationConfig.json");

        public static SAEAMvcApplicationConfig Read()
        {
            if (!FileHelper.Exists(_FilePath))
            {
                Write(SAEAMvcApplicationConfig.Default);
            }
            return SerializeHelper.Deserialize<SAEAMvcApplicationConfig>(FileHelper.ReadString(_FilePath));
        }


        public static void Write(SAEAMvcApplicationConfig config)
        {
            if (config == null) config = SAEAMvcApplicationConfig.Default;

            var json = SerializeHelper.Serialize(config);

            FileHelper.WriteString(_FilePath, json);
        }
    }
}
