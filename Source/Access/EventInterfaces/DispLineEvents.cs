using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.AccessApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("Access", 12,14,15,16)]
	[ComImport, Guid("2E705279-92D1-43CC-A57B-ED48BCCC711D"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface DispLineEvents
	{
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class DispLineEvents_SinkHelper : SinkHelper, DispLineEvents
	{
		#region Static
		
		public static readonly string Id = "2E705279-92D1-43CC-A57B-ED48BCCC711D";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public DispLineEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region Properties

        internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
        }

        #endregion

		#region DispLineEvents Members
		
		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}