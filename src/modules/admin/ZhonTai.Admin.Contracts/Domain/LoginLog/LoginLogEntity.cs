﻿using FreeSql.DataAnnotations;

namespace ZhonTai.Admin.Domain.LoginLog;

/// <summary>
/// 登录日志
/// </summary>
[Table(Name = DbConsts.TableNamePrefix + "login_log", OldName = DbConsts.TableOldNamePrefix + "login_log")]
public partial class LoginLogEntity : LogAbstract
{
}