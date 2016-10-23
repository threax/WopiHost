﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WopiHost
{
    public class WopiHeaders
    {

		public const string WopiOverride = "X-WOPI-Override";

		public const string Lock = "X-WOPI-Lock";
		public const string OldLock = "X-WOPI-OldLock";
		public const string LockFailureReason = "X-WOPI-LockFailureReason";
		public const string LockedByOtherInterface = "X-WOPI-LockedByOtherInterface";

		public const string SuggestedTarget = "X-WOPI-SuggestedTarget";
		public const string RelativeTarget = "X-WOPI-RelativeTarget";
		public const string OverwriteRelativeTarget = "X-WOPI-OverwriteRelativeTarget";

	    public const string CorrelationId = "X-WOPI-CorrelationID";
    }
}
