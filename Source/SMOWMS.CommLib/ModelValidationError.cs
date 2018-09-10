namespace SMOWMS.CommLib
{
    /// <summary>
    /// 基础验证的错误信息
    /// </summary>
    public class ModelValidationError
    {
        /// <summary>
        /// 错误字段
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }
    }
}