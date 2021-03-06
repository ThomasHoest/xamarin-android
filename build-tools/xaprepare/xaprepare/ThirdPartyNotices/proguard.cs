using System;
using System.Collections.Generic;
using System.IO;

namespace Xamarin.Android.Prepare
{
	[TPN]
	class proguard_xamarin_proguard_TPN : ThirdPartyNotice
	{
		static readonly Uri    url         = new Uri ("https://github.com/Guardsquare/proguard");

		public override string LicenseFile => CommonLicenses.GPLv2Path;
		public override string Name        => "Guardsquare/proguard";
		public override Uri    SourceUrl   => url;
		public override string LicenseText => String.Empty;

		public override bool   Include (bool includeExternalDeps, bool includeBuildDeps) => includeExternalDeps;
	}
}
