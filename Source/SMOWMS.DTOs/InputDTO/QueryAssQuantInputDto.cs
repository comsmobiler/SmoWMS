namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产库存查询所需入参
    /// </summary>
    public class QueryAssQuantInputDto
    {
        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 资产大类
        /// </summary>
        public string TYPEID { get; set; }


    }
}