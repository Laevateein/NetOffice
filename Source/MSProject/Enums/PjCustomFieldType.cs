using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjCustomFieldType
	{
		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>65535</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjInvalidCustomField = 65535,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjCostCustomField = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjDateCustomField = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjDurationCustomField = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjFinishCustomField = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjFlagCustomField = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjNumberCustomField = 5,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjStartCustomField = 6,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14,15)]
		 pjTextCustomField = 7
	}
}