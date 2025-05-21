using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UpperAndLowerLimitAcquisition.Helper
{
    public class XmlSerializeHelper<T> where T : class, new()
    {
        /// <summary>
        /// 序列化文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="obj"></param>
        /// <exception cref="Exception"></exception>
        public static void SerializeToFile(string path, T obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                {
                    throw new ArgumentNullException(nameof(path), "路径不能为空或仅包含空白字符。");
                }

                FileInfo fi = new FileInfo(path);
                if (!string.IsNullOrWhiteSpace(fi.DirectoryName) && !Directory.Exists(fi.DirectoryName))
                {
                    Directory.CreateDirectory(fi.DirectoryName);
                }
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        XmlSerializer xs = new XmlSerializer(obj.GetType());
                        xs.Serialize(sw, obj);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /// <summary>
        /// 反序列化文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T DeSerializeFronFile(string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                {
                    throw new ArgumentNullException(nameof(path), "路径不能为空或仅包含空白字符。");
                }

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    var result = xs.Deserialize(fs);
                    
                    if (result is T deserializedObject)
                    {
                        return deserializedObject;
                    }
                    else
                    {
                        throw new InvalidOperationException("反序列化结果不是预期的类型。");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
