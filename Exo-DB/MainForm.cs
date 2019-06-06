using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EXO_DB
{
	public partial class MainForm : KryptonForm
	{
		private List<string> planetHostname = new List<string>();
		private List<string> planetLetter = new List<string>();
		private List<string> planetName = new List<string>();
		private List<string> planetDiscoveryMethod = new List<string>();
		private List<string> planetControversialFlag = new List<string>();
		private List<string> planetNumberofPlanets = new List<string>();
		private List<string> planetOrbitalPeriod = new List<string>();
		private List<string> planetOrbitalPeriodUpperErrorUncertainty = new List<string>();
		private List<string> planetOrbitalPeriodLowerErrorUncertainty = new List<string>();
		private List<string> planetOrbitalPeriodLimitFlag = new List<string>();
		private List<string> planetSemiMajorAxis = new List<string>();
		private List<string> planetSemiMajorAxisUpperErrorUncertainty = new List<string>();
		private List<string> planetSemiMajorAxisLowerErrorUncertainty = new List<string>();
		private List<string> planetSemiMajorAxisLimitFlag = new List<string>();
		private List<string> planetNumericEccentricity = new List<string>();
		private List<string> planetNumericEccentricityUpperErrorUncertainty = new List<string>();
		private List<string> planetNumericEccentricityErrorUncertainty = new List<string>();
		private List<string> planetNumericEccentricityLimitFlag = new List<string>();
		private List<string> planetInclination = new List<string>();
		private List<string> planetInclinationUpperErrorUncertainty = new List<string>();
		private List<string> planetInclinationLowerErrorUncertainty = new List<string>();
		private List<string> planetInclinationLimitFlag = new List<string>();
		private List<string> planetPotentialMassInJupiter = new List<string>();
		private List<string> planetPotentialMassInJupiterUpperErrorUncertainty = new List<string>();
		private List<string> planetPotentialMassInJupiterLowerErrorUncertainty = new List<string>();
		private List<string> planetPotentialMassInJupiterLimitFlag = new List<string>();
		private List<string> planetPotentialMassProvenance = new List<string>();
		private List<string> planetRadiusInJupiter = new List<string>();
		private List<string> planetRadiusInJupiterUpperErrorUncertainty = new List<string>();
		private List<string> planetRadiusInJupiterLowerErrorUncertainty = new List<string>();
		private List<string> planetRadiusInJupiterLimitFlag = new List<string>();
		private List<string> planetDensity = new List<string>();
		private List<string> planetDensityUpperErrorUncertainty = new List<string>();
		private List<string> planetDensityLowerErrorUncertainty = new List<string>();
		private List<string> planetDensityLimitFlag = new List<string>();
		private List<string> planetTtvFlag = new List<string>();
		private List<string> planetKeplerFieldFlag = new List<string>();
		private List<string> planetK2MissionFlag = new List<string>();
		private List<string> planetNumberOfNotes = new List<string>();
		private List<string> rectascension = new List<string>();
		private List<string> rectascensionAsString = new List<string>();
		private List<string> declination = new List<string>();
		private List<string> declinationAsString = new List<string>();
		private List<string> starDistance = new List<string>();
		private List<string> starDistanceUpperErrorUncertainty = new List<string>();
		private List<string> starDistanceLowerErrorUncertainty = new List<string>();
		private List<string> starDistanceLimitFlag = new List<string>();
		private List<string> starOpticalMagnitude = new List<string>();
		private List<string> starOpticalMagnitudeUpperErrorUncertainty = new List<string>();
		private List<string> starOpticalMagnitudeLowerErrorUncertainty = new List<string>();
		private List<string> starOpticalMagnitudeLimitFlag = new List<string>();
		private List<string> starOpticalMagnitudeBand = new List<string>();
		private List<string> gaiaGBand = new List<string>();
		private List<string> gaiaGBandErrorUncertainty = new List<string>();
		private List<string> gaiaGBandLimitFlag = new List<string>();
		private List<string> starEffectiveTemperature = new List<string>();
		private List<string> starEffectiveTemperatureUpperErrorUncertainty = new List<string>();
		private List<string> starEffectiveTemperatureLowerErrorUncertainty = new List<string>();
		private List<string> starEffectiveTemperatureLimitFlag = new List<string>();
		private List<string> starMass = new List<string>();
		private List<string> starMassUpperErrorUncertainty = new List<string>();
		private List<string> starMassLowerErrorUncertainty = new List<string>();
		private List<string> starMassLimitFlag = new List<string>();
		private List<string> starRadius = new List<string>();
		private List<string> starRadiusUpperErrorUncertainty = new List<string>();
		private List<string> starRadiusLowerErrorUncertainty = new List<string>();
		private List<string> starRadiusLimitFlag = new List<string>();
		private List<string> dateLastUpdate = new List<string>();
		private List<string> planetTransitFlag = new List<string>();
		private List<string> planetRadialVelocityFlag = new List<string>();
		private List<string> planetImagingFlag = new List<string>();
		private List<string> planetAstrometryFlag = new List<string>();
		private List<string> planeOrbitalModulationFlag = new List<string>();
		private List<string> planeCircumbinaryFlag = new List<string>();
		private List<string> planetCalculatedAngularSeparation = new List<string>();
		private List<string> planetCalculatedAngularSeparationUpperErrorUncertainty = new List<string>();
		private List<string> planetCalculatedAngularSeparationLowerErrorUncertainty = new List<string>();
		private List<string> planetTimeOfPeriastron = new List<string>();
		private List<string> planetTimeOfPeriastronUpperErrorUncertainty = new List<string>();
		private List<string> planetTimeOfPeriastronLowerErrorUncertainty = new List<string>();
		private List<string> planetTimeOfPeriastronLimitFlag = new List<string>();
		private List<string> planetLongitudeOfPeriastron = new List<string>();
		private List<string> planetLongitudeOfPeriastronUpperErrorUncertainty = new List<string>();
		private List<string> planetLongitudeOfPeriastronLowerErrorUncertainty = new List<string>();
		private List<string> planetLongitudeOfPeriastronLimitFlag = new List<string>();
		private List<string> planetRadialVelocityAmplitude = new List<string>();
		private List<string> planetRadialVelocityAmplitudeUpperErrorUncertainty = new List<string>();
		private List<string> planetRadialVelocityAmplitudeLowerErrorUncertainty = new List<string>();
		private List<string> planetRadialVelocityAmplitudeLimitFlag = new List<string>();
		private List<string> planetEquilibriumTemperature = new List<string>();
		private List<string> planetEquilibriumTemperatureUpperErrorUncertainty = new List<string>();
		private List<string> planetEquilibriumTemperatureLowerErrorUncertainty = new List<string>();
		private List<string> planetEquilibriumTemperatureLimitFlag = new List<string>();
		private List<string> planetInsolationFlux = new List<string>();
		private List<string> planetInsolationFluxUpperErrorUncertainty = new List<string>();
		private List<string> planetInsolationFluxLowerErrorUncertainty = new List<string>();
		private List<string> planetInsolationFluxLimitFlag = new List<string>();
		private List<string> planetMassInJupiter = new List<string>();
		private List<string> planetMassInJupiterUpperErrorUncertainty = new List<string>();
		private List<string> planetMassInJupiterLowerErrorUncertainty = new List<string>();
		private List<string> planetMassInJupiterLimitFlag = new List<string>();
		private List<string> planetMsiniInJupiter = new List<string>();
		private List<string> planetMsiniInJupiterUpperErrorUncertainty = new List<string>();
		private List<string> planetMsiniInJupiterLowerErrorUncertainty = new List<string>();
		private List<string> planetMsiniInJupiterLimitFlag = new List<string>();
		private List<string> planetMassInEarth = new List<string>();
		private List<string> planetMassInEarthUpperErrorUncertainty = new List<string>();
		private List<string> planetMassInEarthLowerErrorUncertainty = new List<string>();
		private List<string> planetMassInEarthLimitFlag = new List<string>();
		private List<string> planetMsiniInEarth = new List<string>();
		private List<string> planetMsiniInEarthUpperErrorUncertainty = new List<string>();
		private List<string> planetMsiniInEarthLowerErrorUncertainty = new List<string>();
		private List<string> planetMsiniInEarthLimitFlag = new List<string>();
		private List<string> planetPotentialMassInEarth = new List<string>();
		private List<string> planetPotentialMassInEarthUpperErrorUncertainty = new List<string>();
		private List<string> planetPotentialMassInEarthLowerErrorUncertainty = new List<string>();
		private List<string> planetPotentialMassInEarthLimitFlag = new List<string>();
		private List<string> planetRadiusInEarth = new List<string>();
		private List<string> planetRadiusInEarthUpperErrorUncertainty = new List<string>();
		private List<string> planetRadiusInEarthLowerErrorUncertainty = new List<string>();
		private List<string> planetRadiusInEarthLimitFlag = new List<string>();
		private List<string> planetRadiusInSun = new List<string>();
		private List<string> planetRadiusInSunUpperErrorUncertainty = new List<string>();
		private List<string> planetRadiusInSunLowerErrorUncertainty = new List<string>();
		private List<string> planetRadiusInSunLimitFlag = new List<string>();
		private List<string> planetTransitDepth = new List<string>();
		private List<string> planetTransitDepthUpperErrorUncertainty = new List<string>();
		private List<string> planetTransitDepthLowerErrorUncertainty = new List<string>();
		private List<string> planetTransitDepthLimitFlag = new List<string>();
		private List<string> planetTransitDuration = new List<string>();
		private List<string> planetTransitDurationUpperErrorUncertainty = new List<string>();
		private List<string> planetTransitDurationLowerErrorUncertainty = new List<string>();
		private List<string> planetTransitDurationLimitFlag = new List<string>();
		private List<string> planetTransitMidpoint = new List<string>();
		private List<string> planetTransitMidpointUpperErrorUncertainty = new List<string>();
		private List<string> planetTransitMidpointLowerErrorUncertainty = new List<string>();
		private List<string> planetTransitMidpointLimitFlag = new List<string>();
		private List<string> planetTimeSystemReference = new List<string>();
		private List<string> planetImpactParameter = new List<string>();
		private List<string> planetImpactParameterUpperErrorUncertainty = new List<string>();
		private List<string> planetImpactParameterLowerErrorUncertainty = new List<string>();
		private List<string> planetImpactParameterLimitFlag = new List<string>();
		private List<string> planetOccultationDepth = new List<string>();
		private List<string> planetOccultationDepthUpperErrorUncertainty = new List<string>();
		private List<string> planetOccultationDepthLowerErrorUncertainty = new List<string>();
		private List<string> planetOccultationDepthLimitFlag = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadius = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadiusUpperErrorUncertainty = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadiusLowerErrorUncertainty = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadiusLimitFlag = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadius = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadiusUpperErrorUncertainty = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadiusLowerErrorUncertainty = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadiusLimitFlag = new List<string>();
		private List<string> planetDefaultReference = new List<string>();
		private List<string> planetYearOfDiscovery = new List<string>();
		private List<string> planetDiscoveryReference = new List<string>();
		private List<string> planetDiscoveryLocale = new List<string>();
		private List<string> planetDiscoveryFacility = new List<string>();
		private List<string> planetDiscoveryTelescope = new List<string>();
		private List<string> planeDiscoveryInstrument = new List<string>();
		private List<string> planetStatus = new List<string>();
		private List<string> planetNumberOfMoonsInSystem = new List<string>();
		private List<string> planetNumberOfStellarAndPlanetParameters = new List<string>();
		private List<string> planetNumberOfStellarAndPlanetReferences = new List<string>();
		private List<string> planetLinkToExoplanetEncyclopaedia = new List<string>();
		private List<string> planetLinkToExoplanetDataExplorer = new List<string>();
		private List<string> planetPublicationDate = new List<string>();
		private List<string> HdName = new List<string>();
		private List<string> HipName = new List<string>();
		//st_rah,st_glon,st_glat,st_elon,st_elat,st_plx,st_plxerr1,st_plxerr2,st_plxlim,gaia_plx,gaia_plxerr1,gaia_plxerr2,gaia_plxlim,gaia_dist,gaia_disterr1,gaia_disterr2,gaia_distlim,st_pmra,st_pmraerr,st_pmralim,st_pmdec,st_pmdecerr,st_pmdeclim,st_pm,st_pmerr,st_pmlim,gaia_pmra,gaia_pmraerr,gaia_pmralim,gaia_pmdec,gaia_pmdecerr,gaia_pmdeclim,gaia_pm,gaia_pmerr,gaia_pmlim,st_radv,st_radverr1,st_radverr2,st_radvlim,st_sp,st_spstr,st_sperr,st_splim,st_logg,st_loggerr1,st_loggerr2,st_logglim,st_lum,st_lumerr1,st_lumerr2,st_lumlim,st_dens,st_denserr1,st_denserr2,st_denslim,st_metfe,st_metfeerr1,st_metfeerr2,st_metfelim,st_metratio,st_age,st_ageerr1,st_ageerr2,st_agelim,st_vsini,st_vsinierr1,st_vsinierr2,st_vsinilim,st_acts,st_actserr,st_actslim,st_actr,st_actrerr,st_actrlim,st_actlx,st_actlxerr,st_actlxlim,swasp_id,st_nts,st_nplc,st_nglc,st_nrvc,st_naxa,st_nimg,st_nspec,st_uj,st_ujerr,st_ujlim,st_vj,st_vjerr,st_vjlim,st_bj,st_bjerr,st_bjlim,st_rc,st_rcerr,st_rclim,st_ic,st_icerr,st_iclim,st_j,st_jerr,st_jlim,st_h,st_herr,st_hlim,st_k,st_kerr,st_klim,st_wise1,st_wise1err,st_wise1lim,st_wise2,st_wise2err,st_wise2lim,st_wise3,st_wise3err,st_wise3lim,st_wise4,st_wise4err,st_wise4lim,st_irac1,st_irac1err,st_irac1lim,st_irac2,st_irac2err,st_irac2lim,st_irac3,st_irac3err,st_irac3lim,st_irac4,st_irac4err,st_irac4lim,st_mips1,st_mips1err,st_mips1lim,st_mips2,st_mips2err,st_mips2lim,st_mips3,st_mips3err,st_mips3lim,st_iras1,st_iras1err,st_iras1lim,st_iras2,st_iras2err,st_iras2lim,st_iras3,st_iras3err,st_iras3lim,st_iras4,st_iras4err,st_iras4lim,st_photn,st_umbj,st_umbjerr,st_umbjlim,st_bmvj,st_bmvjerr,st_bmvjlim,st_vjmic,st_vjmicerr,st_vjmiclim,st_vjmrc,st_vjmrcerr,st_vjmrclim,st_jmh2,st_jmh2err,st_jmh2lim,st_hmk2,st_hmk2err,st_hmk2lim,st_jmk2,st_jmk2err,st_jmk2lim,st_bmy,st_bmyerr,st_bmylim,st_m1,st_m1err,st_m1lim,st_c1,st_c1err,st_c1lim,st_colorn";

		#region Assemblyattributaccessoren

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		private void ClearAllLists()
		{
			planetHostname.Clear();
			planetLetter.Clear();
			planetName.Clear();
			planetDiscoveryMethod.Clear();
			planetControversialFlag.Clear();
			planetNumberofPlanets.Clear();
			planetOrbitalPeriod.Clear();
			planetOrbitalPeriodUpperErrorUncertainty.Clear();
			planetOrbitalPeriodLowerErrorUncertainty.Clear();
			planetOrbitalPeriodLimitFlag.Clear();
			planetSemiMajorAxis.Clear();
			planetSemiMajorAxisUpperErrorUncertainty.Clear();
			planetSemiMajorAxisLowerErrorUncertainty.Clear();
			planetSemiMajorAxisLimitFlag.Clear();
			planetNumericEccentricity.Clear();
			planetNumericEccentricityUpperErrorUncertainty.Clear();
			planetNumericEccentricityErrorUncertainty.Clear();
			planetNumericEccentricityLimitFlag.Clear();
			planetInclination.Clear();
			planetInclinationUpperErrorUncertainty.Clear();
			planetInclinationLowerErrorUncertainty.Clear();
			planetInclinationLimitFlag.Clear();
			planetPotentialMassInJupiter.Clear();
			planetPotentialMassInJupiterUpperErrorUncertainty.Clear();
			planetPotentialMassInJupiterLowerErrorUncertainty.Clear();
			planetPotentialMassInJupiterLimitFlag.Clear();
			planetPotentialMassProvenance.Clear();
			planetRadiusInJupiter.Clear();
			planetRadiusInJupiterUpperErrorUncertainty.Clear();
			planetRadiusInJupiterLowerErrorUncertainty.Clear();
			planetRadiusInJupiterLimitFlag.Clear();
			planetDensity.Clear();
			planetDensityUpperErrorUncertainty.Clear();
			planetDensityLowerErrorUncertainty.Clear();
			planetDensityLimitFlag.Clear();
			planetTtvFlag.Clear();
			planetKeplerFieldFlag.Clear();
			planetK2MissionFlag.Clear();
			planetNumberOfNotes.Clear();
		}

		private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				toolStripStatusLabel.Text = ((TextBox)sender).AccessibleDescription;
			}
			else if (sender is Button)
			{
				toolStripStatusLabel.Text = ((Button)sender).AccessibleDescription;
			}
			else if (sender is RadioButton)
			{
				toolStripStatusLabel.Text = ((RadioButton)sender).AccessibleDescription;
			}
			else if (sender is DateTimePicker)
			{
				toolStripStatusLabel.Text = ((DateTimePicker)sender).AccessibleDescription;
			}
			else if (sender is Label)
			{
				toolStripStatusLabel.Text = ((Label)sender).AccessibleDescription;
			}
			else if (sender is KryptonButton)
			{
				toolStripStatusLabel.Text = ((KryptonButton)sender).AccessibleDescription;
			}
			else if (sender is KryptonPage)
			{
				toolStripStatusLabel.Text = ((KryptonButton)sender).AccessibleDescription;
			}
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabel.Text = string.Empty;
		}

		private void OpenInformationForm()
		{
			new InfoForm().ShowDialog();
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void ToolStripButtonInformation_Click(object sender, EventArgs e)
		{
			OpenInformationForm();
		}

		private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
		{
			OpenInformationForm();
		}

		private void KryptonButtonLoadInternalDatabase_Click(object sender, EventArgs e)
		{
			ClearAllLists();

			kryptonWrapLabelStatusOfProgressingDatabase.Text = string.Empty;
			Assembly thisAssembly = Assembly.GetExecutingAssembly();
			Stream resourceStream = thisAssembly.GetManifestResourceStream(name: "EXO_DB.exoplanets.csv");
			using (CsvReader csv = new CsvReader(reader: new StreamReader(stream: resourceStream), hasHeaders: true))
			{
				int fieldCount = csv.FieldCount;
				string[] headers = csv.GetFieldHeaders();
				progressBarLoadingDatabase.Show();
				progressBarLoadingDatabase.Style = ProgressBarStyle.Marquee;
				kryptonWrapLabelStatusOfProgressingDatabase.Text = "Datenbank wird geladen...";
				while (csv.ReadNextRecord())
				{
					for (int i = 0; i < fieldCount; i++)
					{
						//pl_radj,pl_radjerr1,pl_radjerr2,pl_radjlim,pl_dens,pl_denserr1,pl_denserr2,pl_denslim,pl_ttvflag,pl_kepflag,pl_k2flag,pl_nnotes,ra_str,ra,dec_str,dec,st_dist,st_disterr1,st_disterr2,st_distlim,st_optmag,st_optmagerr,st_optmaglim,st_optband,gaia_gmag,gaia_gmagerr,gaia_gmaglim,st_teff,st_tefferr1,st_tefferr2,st_tefflim,st_mass,st_masserr1,st_masserr2,st_masslim,st_rad,st_raderr1,st_raderr2,st_radlim,rowupdate,pl_tranflag,pl_rvflag,pl_imgflag,pl_astflag,pl_omflag,pl_cbflag,pl_angsep,pl_angseperr1,pl_angseperr2,pl_orbtper,pl_orbtpererr1,pl_orbtpererr2,pl_orbtperlim,pl_orblper,pl_orblpererr1,pl_orblpererr2,pl_orblperlim,pl_rvamp,pl_rvamperr1,pl_rvamperr2,pl_rvamplim,pl_eqt,pl_eqterr1,pl_eqterr2,pl_eqtlim,pl_insol,pl_insolerr1,pl_insolerr2,pl_insollim,pl_massj,pl_massjerr1,pl_massjerr2,pl_massjlim,pl_msinij,pl_msinijerr1,pl_msinijerr2,pl_msinijlim,pl_masse,pl_masseerr1,pl_masseerr2,pl_masselim,pl_msinie,pl_msinieerr1,pl_msinieerr2,pl_msinielim,pl_bmasse,pl_bmasseerr1,pl_bmasseerr2,pl_bmasselim,pl_rade,pl_radeerr1,pl_radeerr2,pl_radelim,pl_rads,pl_radserr1,pl_radserr2,pl_radslim,pl_trandep,pl_trandeperr1,pl_trandeperr2,pl_trandeplim,pl_trandur,pl_trandurerr1,pl_trandurerr2,pl_trandurlim,pl_tranmid,pl_tranmiderr1,pl_tranmiderr2,pl_tranmidlim,pl_tsystemref,pl_imppar,pl_impparerr1,pl_impparerr2,pl_impparlim,pl_occdep,pl_occdeperr1,pl_occdeperr2,pl_occdeplim,pl_ratdor,pl_ratdorerr1,pl_ratdorerr2,pl_ratdorlim,pl_ratror,pl_ratrorerr1,pl_ratrorerr2,pl_ratrorlim,pl_def_reflink,pl_disc,pl_disc_reflink,pl_locale,pl_facility,pl_telescope,pl_instrument,pl_status,pl_mnum,pl_st_npar,pl_st_nref,pl_pelink,pl_edelink,pl_publ_date,hd_name,hip_name,st_rah,st_glon,st_glat,st_elon,st_elat,st_plx,st_plxerr1,st_plxerr2,st_plxlim,gaia_plx,gaia_plxerr1,gaia_plxerr2,gaia_plxlim,gaia_dist,gaia_disterr1,gaia_disterr2,gaia_distlim,st_pmra,st_pmraerr,st_pmralim,st_pmdec,st_pmdecerr,st_pmdeclim,st_pm,st_pmerr,st_pmlim,gaia_pmra,gaia_pmraerr,gaia_pmralim,gaia_pmdec,gaia_pmdecerr,gaia_pmdeclim,gaia_pm,gaia_pmerr,gaia_pmlim,st_radv,st_radverr1,st_radverr2,st_radvlim,st_sp,st_spstr,st_sperr,st_splim,st_logg,st_loggerr1,st_loggerr2,st_logglim,st_lum,st_lumerr1,st_lumerr2,st_lumlim,st_dens,st_denserr1,st_denserr2,st_denslim,st_metfe,st_metfeerr1,st_metfeerr2,st_metfelim,st_metratio,st_age,st_ageerr1,st_ageerr2,st_agelim,st_vsini,st_vsinierr1,st_vsinierr2,st_vsinilim,st_acts,st_actserr,st_actslim,st_actr,st_actrerr,st_actrlim,st_actlx,st_actlxerr,st_actlxlim,swasp_id,st_nts,st_nplc,st_nglc,st_nrvc,st_naxa,st_nimg,st_nspec,st_uj,st_ujerr,st_ujlim,st_vj,st_vjerr,st_vjlim,st_bj,st_bjerr,st_bjlim,st_rc,st_rcerr,st_rclim,st_ic,st_icerr,st_iclim,st_j,st_jerr,st_jlim,st_h,st_herr,st_hlim,st_k,st_kerr,st_klim,st_wise1,st_wise1err,st_wise1lim,st_wise2,st_wise2err,st_wise2lim,st_wise3,st_wise3err,st_wise3lim,st_wise4,st_wise4err,st_wise4lim,st_irac1,st_irac1err,st_irac1lim,st_irac2,st_irac2err,st_irac2lim,st_irac3,st_irac3err,st_irac3lim,st_irac4,st_irac4err,st_irac4lim,st_mips1,st_mips1err,st_mips1lim,st_mips2,st_mips2err,st_mips2lim,st_mips3,st_mips3err,st_mips3lim,st_iras1,st_iras1err,st_iras1lim,st_iras2,st_iras2err,st_iras2lim,st_iras3,st_iras3err,st_iras3lim,st_iras4,st_iras4err,st_iras4lim,st_photn,st_umbj,st_umbjerr,st_umbjlim,st_bmvj,st_bmvjerr,st_bmvjlim,st_vjmic,st_vjmicerr,st_vjmiclim,st_vjmrc,st_vjmrcerr,st_vjmrclim,st_jmh2,st_jmh2err,st_jmh2lim,st_hmk2,st_hmk2err,st_hmk2lim,st_jmk2,st_jmk2err,st_jmk2lim,st_bmy,st_bmyerr,st_bmylim,st_m1,st_m1err,st_m1lim,st_c1,st_c1err,st_c1lim,st_colorn";
						switch (headers[i])
						{
							case "pl_hostname": planetHostname.Add(item: csv[i]); break;
							case "pl_letter": planetLetter.Add(item: csv[i]); break;
							case "pl_name": planetName.Add(item: csv[i]); break;
							case "pl_discmethod": planetDiscoveryMethod.Add(item: csv[i]); break;
							case "pl_controvflag": planetControversialFlag.Add(item: csv[i]); break;
							case "pl_pnum": planetNumberofPlanets.Add(item: csv[i]); break;
							case "pl_orbper": planetOrbitalPeriod.Add(item: csv[i]); break;
							case "pl_orbpererr1": planetOrbitalPeriodUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbpererr2": planetOrbitalPeriodLowerErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbperlim": planetOrbitalPeriodLimitFlag.Add(item: csv[i]); break;
							case "pl_orbsmax": planetSemiMajorAxis.Add(item: csv[i]); break;
							case "pl_orbsmaxerr1": planetSemiMajorAxisUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbsmaxerr2": planetSemiMajorAxisLowerErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbsmaxlim": planetSemiMajorAxisLimitFlag.Add(item: csv[i]); break;
							case "pl_orbeccen": planetNumericEccentricity.Add(item: csv[i]); break;
							case "pl_orbeccenerr1": planetNumericEccentricityUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbeccenerr2": planetNumericEccentricityErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbeccenlim": planetNumericEccentricityLimitFlag.Add(item: csv[i]); break;
							case "pl_orbincl": planetInclination.Add(item: csv[i]); break;
							case "pl_orbinclerr1": planetInclinationUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbinclerr2": planetInclinationLowerErrorUncertainty.Add(item: csv[i]); break;
							case "pl_orbincllim": planetInclinationLimitFlag.Add(item: csv[i]); break;
							case "pl_bmassj": planetPotentialMassInJupiter.Add(item: csv[i]); break;
							case "pl_bmassjerr1": planetPotentialMassInJupiterUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_bmassjerr2": planetPotentialMassInJupiterLowerErrorUncertainty.Add(item: csv[i]); break;
							case "pl_bmassjlim": planetPotentialMassInJupiterLimitFlag.Add(item: csv[i]); break;
							case "pl_bmassprov": planetPotentialMassProvenance.Add(item: csv[i]); break;
							case "pl_radj": planetRadiusInJupiter.Add(item: csv[i]); break;
							case "pl_radjerr1": planetRadiusInJupiterUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_radjerr2": planetRadiusInJupiterLowerErrorUncertainty.Add(item: csv[i]); break;
							case "pl_radjlim": planetRadiusInJupiterLimitFlag.Add(item: csv[i]); break;
							case "pl_dens": planetDensity.Add(item: csv[i]); break;
							case "pl_denserr1": planetDensityUpperErrorUncertainty.Add(item: csv[i]); break;
							case "pl_denserr2": planetDensityLowerErrorUncertainty.Add(item: csv[i]); break;
							case "pl_denslim": planetDensityLimitFlag.Add(item: csv[i]); break;
							case "pl_ttvflag": planetTtvFlag.Add(item: csv[i]); break;
							case "pl_kepflag": planetKeplerFieldFlag.Add(item: csv[i]); break;
							case "pl_k2flag": planetK2MissionFlag.Add(item: csv[i]); break;
							case "pl_nnotes":	planetNumberOfNotes.Add(item: csv[i]); break;
							//ra_str,ra,dec_str,dec,st_dist,st_disterr1,st_disterr2,st_distlim,st_optmag,st_optmagerr,st_optmaglim,st_optband,gaia_gmag,gaia_gmagerr,gaia_gmaglim,st_teff,st_tefferr1,st_tefferr2,st_tefflim,st_mass,st_masserr1,st_masserr2,st_masslim,st_rad,st_raderr1,st_raderr2,st_radlim,rowupdate,pl_tranflag,pl_rvflag,pl_imgflag,pl_astflag,pl_omflag,pl_cbflag,pl_angsep,pl_angseperr1,pl_angseperr2,pl_orbtper,pl_orbtpererr1,pl_orbtpererr2,pl_orbtperlim,pl_orblper,pl_orblpererr1,pl_orblpererr2,pl_orblperlim,pl_rvamp,pl_rvamperr1,pl_rvamperr2,pl_rvamplim,pl_eqt,pl_eqterr1,pl_eqterr2,pl_eqtlim,pl_insol,pl_insolerr1,pl_insolerr2,pl_insollim,pl_massj,pl_massjerr1,pl_massjerr2,pl_massjlim,pl_msinij,pl_msinijerr1,pl_msinijerr2,pl_msinijlim,pl_masse,pl_masseerr1,pl_masseerr2,pl_masselim,pl_msinie,pl_msinieerr1,pl_msinieerr2,pl_msinielim,pl_bmasse,pl_bmasseerr1,pl_bmasseerr2,pl_bmasselim,pl_rade,pl_radeerr1,pl_radeerr2,pl_radelim,pl_rads,pl_radserr1,pl_radserr2,pl_radslim,pl_trandep,pl_trandeperr1,pl_trandeperr2,pl_trandeplim,pl_trandur,pl_trandurerr1,pl_trandurerr2,pl_trandurlim,pl_tranmid,pl_tranmiderr1,pl_tranmiderr2,pl_tranmidlim,pl_tsystemref,pl_imppar,pl_impparerr1,pl_impparerr2,pl_impparlim,pl_occdep,pl_occdeperr1,pl_occdeperr2,pl_occdeplim,pl_ratdor,pl_ratdorerr1,pl_ratdorerr2,pl_ratdorlim,pl_ratror,pl_ratrorerr1,pl_ratrorerr2,pl_ratrorlim,pl_def_reflink,pl_disc,pl_disc_reflink,pl_locale,pl_facility,pl_telescope,pl_instrument,pl_status,pl_mnum,pl_st_npar,pl_st_nref,pl_pelink,pl_edelink,pl_publ_date,hd_name,hip_name,st_rah,st_glon,st_glat,st_elon,st_elat,st_plx,st_plxerr1,st_plxerr2,st_plxlim,gaia_plx,gaia_plxerr1,gaia_plxerr2,gaia_plxlim,gaia_dist,gaia_disterr1,gaia_disterr2,gaia_distlim,st_pmra,st_pmraerr,st_pmralim,st_pmdec,st_pmdecerr,st_pmdeclim,st_pm,st_pmerr,st_pmlim,gaia_pmra,gaia_pmraerr,gaia_pmralim,gaia_pmdec,gaia_pmdecerr,gaia_pmdeclim,gaia_pm,gaia_pmerr,gaia_pmlim,st_radv,st_radverr1,st_radverr2,st_radvlim,st_sp,st_spstr,st_sperr,st_splim,st_logg,st_loggerr1,st_loggerr2,st_logglim,st_lum,st_lumerr1,st_lumerr2,st_lumlim,st_dens,st_denserr1,st_denserr2,st_denslim,st_metfe,st_metfeerr1,st_metfeerr2,st_metfelim,st_metratio,st_age,st_ageerr1,st_ageerr2,st_agelim,st_vsini,st_vsinierr1,st_vsinierr2,st_vsinilim,st_acts,st_actserr,st_actslim,st_actr,st_actrerr,st_actrlim,st_actlx,st_actlxerr,st_actlxlim,swasp_id,st_nts,st_nplc,st_nglc,st_nrvc,st_naxa,st_nimg,st_nspec,st_uj,st_ujerr,st_ujlim,st_vj,st_vjerr,st_vjlim,st_bj,st_bjerr,st_bjlim,st_rc,st_rcerr,st_rclim,st_ic,st_icerr,st_iclim,st_j,st_jerr,st_jlim,st_h,st_herr,st_hlim,st_k,st_kerr,st_klim,st_wise1,st_wise1err,st_wise1lim,st_wise2,st_wise2err,st_wise2lim,st_wise3,st_wise3err,st_wise3lim,st_wise4,st_wise4err,st_wise4lim,st_irac1,st_irac1err,st_irac1lim,st_irac2,st_irac2err,st_irac2lim,st_irac3,st_irac3err,st_irac3lim,st_irac4,st_irac4err,st_irac4lim,st_mips1,st_mips1err,st_mips1lim,st_mips2,st_mips2err,st_mips2lim,st_mips3,st_mips3err,st_mips3lim,st_iras1,st_iras1err,st_iras1lim,st_iras2,st_iras2err,st_iras2lim,st_iras3,st_iras3err,st_iras3lim,st_iras4,st_iras4err,st_iras4lim,st_photn,st_umbj,st_umbjerr,st_umbjlim,st_bmvj,st_bmvjerr,st_bmvjlim,st_vjmic,st_vjmicerr,st_vjmiclim,st_vjmrc,st_vjmrcerr,st_vjmrclim,st_jmh2,st_jmh2err,st_jmh2lim,st_hmk2,st_hmk2err,st_hmk2lim,st_jmk2,st_jmk2err,st_jmk2lim,st_bmy,st_bmyerr,st_bmylim,st_m1,st_m1err,st_m1lim,st_c1,st_c1err,st_c1lim,st_colorn";
						}
					}
				}
				progressBarLoadingDatabase.Hide();
				MessageBox.Show(text: "Die Datenbank wurde erfolgreich eingelesen.", caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}

		}

		private void KryptonButtonLoadOnlineDatabase_Click(object sender, EventArgs e)
		{
			ClearAllLists();
		}

		private void KryptonButtonLoadExternalDatabase_Click(object sender, EventArgs e)
		{
			ClearAllLists();
		}

		private void KryptonButtonSaveInternalDatabase_Click(object sender, EventArgs e)
		{
		}

		private void KryptonButtonSaveOnlineDatabase_Click(object sender, EventArgs e)
		{
		}

		private void KryptonButtonLoadInternalDatabase_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonLoadOnlineDatabase_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonLoadExternalDatabase_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonSaveInternalDatabase_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonSaveOnlineDatabase_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonLoadInternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonLoadOnlineDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonLoadExternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonSaveInternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonSaveOnlineDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonLoadInternalDatabase_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonLoadOnlineDatabase_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonLoadExternalDatabase_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonSaveInternalDatabase_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonSaveOnlineDatabase_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonLoadInternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonLoadOnlineDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonLoadExternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonSaveInternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonSaveOnlineDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			kryptonWrapLabelStatusOfProgressingDatabase.Text = string.Empty;
			kryptonWrapLabelStatusOfProgressingDatabase.Hide();
			progressBarLoadingDatabase.Hide();
		}
	}
}
