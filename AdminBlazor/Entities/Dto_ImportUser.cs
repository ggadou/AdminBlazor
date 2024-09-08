using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Excel;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBlazor.Entities;
/// <summary>
/// 用户导入模板
/// </summary>
[ExcelImporter(IsLabelingError = true)]
[ExcelExporter(Name = "测试", TableStyle = TableStyles.Dark9, AutoFitAllColumn = true, AutoFitMaxRows = 5000, FontSize = 12)]
public class Dto_ImportUser
{
    /// <summary>
    /// 账号
    /// </summary>
    [ImporterHeader(Name = "登陆名")]
    [ExporterHeader("登陆名")]
    [Required(ErrorMessage = "登陆名不能为空")]
    [MaxLength(30, ErrorMessage = "登陆名字数超出最大限制,请修改!")]
    public string Username { get; set; }
    [ImporterHeader(Name = "用户名称")]
    [ExporterHeader("用户名称")]
    [Required(ErrorMessage = "用户名称不能为空")]
    [MaxLength(30, ErrorMessage = "用户名称字数超出最大限制,请修改!")]
    public string NickName { get; set; }

    [ImporterHeader(Name = "初始密码")]
    [ExporterHeader("初始密码")]
    [MaxLength(30, ErrorMessage = "初始密码超出最大限制,请修改!")]
    public string Password { get; set; }

    [ImporterHeader(Name = "角色")]
    [ExporterHeader("角色")]
    public string Role { get; set; }
}
