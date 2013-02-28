using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jieshuibanxx_1.Common
{
    /// <summary>
    /// 命令按钮的类型
    /// </summary>
    public enum  CommandType
    {
        /// <summary>
        /// 新建
        /// </summary>
        New,
        /// <summary>
        /// 查看
        /// </summary>
        View,
        /// <summary>
        /// 查询
        /// </summary>
        Find,
        /// <summary>
        /// 修改
        /// </summary>
        Modify,
        /// <summary>
        /// 删除
        /// </summary>
        Delete,
        /// <summary>
        /// 取消
        /// </summary>
        Cancel,
        /// <summary>
        /// 更新
        /// </summary>
        Update,
        /// <summary>
        /// 打印
        /// </summary>
        Print,
        /// <summary>
        /// 预览
        /// </summary>
        PrintPreview,
        /// <summary>
        /// 保存
        /// </summary>
        Save,
        /// <summary>
        /// 统计
        /// </summary>
        Stat,
        /// <summary>
        /// 其它(没有图标)
        /// </summary>
        Other,
        /// <summary>
        /// 下载
        /// </summary>
        Download,
        /// <summary>
        /// 导出Excel
        /// </summary>
        ExportExcel
    }
}
