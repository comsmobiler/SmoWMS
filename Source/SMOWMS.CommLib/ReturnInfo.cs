namespace SMOWMS.CommLib
{
    /// <summary>
    /// 用于返回执行登录,增删改等操作执行结果的信息
    /// </summary>
    public class ReturnInfo
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 详细的错误信息
        /// </summary>
        public string ErrorInfo { get; set; }
    }
}
