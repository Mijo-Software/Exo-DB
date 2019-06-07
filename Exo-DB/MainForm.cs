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
		private List<string> planetOrbitalPeriodUpperUncertainty = new List<string>();
		private List<string> planetOrbitalPeriodLowerUncertainty = new List<string>();
		private List<string> planetOrbitalPeriodLimitFlag = new List<string>();
		private List<string> planetSemiMajorAxis = new List<string>();
		private List<string> planetSemiMajorAxisUpperUncertainty = new List<string>();
		private List<string> planetSemiMajorAxisLowerUncertainty = new List<string>();
		private List<string> planetSemiMajorAxisLimitFlag = new List<string>();
		private List<string> planetNumericEccentricity = new List<string>();
		private List<string> planetNumericEccentricityUpperUncertainty = new List<string>();
		private List<string> planetNumericEccentricityUncertainty = new List<string>();
		private List<string> planetNumericEccentricityLimitFlag = new List<string>();
		private List<string> planetInclination = new List<string>();
		private List<string> planetInclinationUpperUncertainty = new List<string>();
		private List<string> planetInclinationLowerUncertainty = new List<string>();
		private List<string> planetInclinationLimitFlag = new List<string>();
		private List<string> planetPotentialMassInJupiter = new List<string>();
		private List<string> planetPotentialMassInJupiterUpperUncertainty = new List<string>();
		private List<string> planetPotentialMassInJupiterLowerUncertainty = new List<string>();
		private List<string> planetPotentialMassInJupiterLimitFlag = new List<string>();
		private List<string> planetPotentialMassProvenance = new List<string>();
		private List<string> planetRadiusInJupiter = new List<string>();
		private List<string> planetRadiusInJupiterUpperUncertainty = new List<string>();
		private List<string> planetRadiusInJupiterLowerUncertainty = new List<string>();
		private List<string> planetRadiusInJupiterLimitFlag = new List<string>();
		private List<string> planetDensity = new List<string>();
		private List<string> planetDensityUpperUncertainty = new List<string>();
		private List<string> planetDensityLowerUncertainty = new List<string>();
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
		private List<string> starDistanceUpperUncertainty = new List<string>();
		private List<string> starDistanceLowerUncertainty = new List<string>();
		private List<string> starDistanceLimitFlag = new List<string>();
		private List<string> starOpticalMagnitude = new List<string>();
		private List<string> starOpticalMagnitudeUncertainty = new List<string>();
		private List<string> starOpticalMagnitudeLimitFlag = new List<string>();
		private List<string> starOpticalMagnitudeBand = new List<string>();
		private List<string> gaiaGBand = new List<string>();
		private List<string> gaiaGBandUncertainty = new List<string>();
		private List<string> gaiaGBandLimitFlag = new List<string>();
		private List<string> starEffectiveTemperature = new List<string>();
		private List<string> starEffectiveTemperatureUpperUncertainty = new List<string>();
		private List<string> starEffectiveTemperatureLowerUncertainty = new List<string>();
		private List<string> starEffectiveTemperatureLimitFlag = new List<string>();
		private List<string> starMass = new List<string>();
		private List<string> starMassUpperUncertainty = new List<string>();
		private List<string> starMassLowerUncertainty = new List<string>();
		private List<string> starMassLimitFlag = new List<string>();
		private List<string> starRadius = new List<string>();
		private List<string> starRadiusUpperUncertainty = new List<string>();
		private List<string> starRadiusLowerUncertainty = new List<string>();
		private List<string> starRadiusLimitFlag = new List<string>();
		private List<string> dateLastUpdate = new List<string>();
		private List<string> planetTransitFlag = new List<string>();
		private List<string> planetRadialVelocityFlag = new List<string>();
		private List<string> planetImagingFlag = new List<string>();
		private List<string> planetAstrometryFlag = new List<string>();
		private List<string> planetOrbitalModulationFlag = new List<string>();
		private List<string> planetCircumbinaryFlag = new List<string>();
		private List<string> planetCalculatedAngularSeparation = new List<string>();
		private List<string> planetCalculatedAngularSeparationUpperUncertainty = new List<string>();
		private List<string> planetCalculatedAngularSeparationLowerUncertainty = new List<string>();
		private List<string> planetTimeOfPeriastron = new List<string>();
		private List<string> planetTimeOfPeriastronUpperUncertainty = new List<string>();
		private List<string> planetTimeOfPeriastronLowerUncertainty = new List<string>();
		private List<string> planetTimeOfPeriastronLimitFlag = new List<string>();
		private List<string> planetLongitudeOfPeriastron = new List<string>();
		private List<string> planetLongitudeOfPeriastronUpperUncertainty = new List<string>();
		private List<string> planetLongitudeOfPeriastronLowerUncertainty = new List<string>();
		private List<string> planetLongitudeOfPeriastronLimitFlag = new List<string>();
		private List<string> planetRadialVelocityAmplitude = new List<string>();
		private List<string> planetRadialVelocityAmplitudeUpperUncertainty = new List<string>();
		private List<string> planetRadialVelocityAmplitudeLowerUncertainty = new List<string>();
		private List<string> planetRadialVelocityAmplitudeLimitFlag = new List<string>();
		private List<string> planetEquilibriumTemperature = new List<string>();
		private List<string> planetEquilibriumTemperatureUpperUncertainty = new List<string>();
		private List<string> planetEquilibriumTemperatureLowerUncertainty = new List<string>();
		private List<string> planetEquilibriumTemperatureLimitFlag = new List<string>();
		private List<string> planetInsolationFlux = new List<string>();
		private List<string> planetInsolationFluxUpperUncertainty = new List<string>();
		private List<string> planetInsolationFluxLowerUncertainty = new List<string>();
		private List<string> planetInsolationFluxLimitFlag = new List<string>();
		private List<string> planetMassInJupiter = new List<string>();
		private List<string> planetMassInJupiterUpperUncertainty = new List<string>();
		private List<string> planetMassInJupiterLowerUncertainty = new List<string>();
		private List<string> planetMassInJupiterLimitFlag = new List<string>();
		private List<string> planetMsiniInJupiter = new List<string>();
		private List<string> planetMsiniInJupiterUpperUncertainty = new List<string>();
		private List<string> planetMsiniInJupiterLowerUncertainty = new List<string>();
		private List<string> planetMsiniInJupiterLimitFlag = new List<string>();
		private List<string> planetMassInEarth = new List<string>();
		private List<string> planetMassInEarthUpperUncertainty = new List<string>();
		private List<string> planetMassInEarthLowerUncertainty = new List<string>();
		private List<string> planetMassInEarthLimitFlag = new List<string>();
		private List<string> planetMsiniInEarth = new List<string>();
		private List<string> planetMsiniInEarthUpperUncertainty = new List<string>();
		private List<string> planetMsiniInEarthLowerUncertainty = new List<string>();
		private List<string> planetMsiniInEarthLimitFlag = new List<string>();
		private List<string> planetPotentialMassInEarth = new List<string>();
		private List<string> planetPotentialMassInEarthUpperUncertainty = new List<string>();
		private List<string> planetPotentialMassInEarthLowerUncertainty = new List<string>();
		private List<string> planetPotentialMassInEarthLimitFlag = new List<string>();
		private List<string> planetRadiusInEarth = new List<string>();
		private List<string> planetRadiusInEarthUpperUncertainty = new List<string>();
		private List<string> planetRadiusInEarthLowerUncertainty = new List<string>();
		private List<string> planetRadiusInEarthLimitFlag = new List<string>();
		private List<string> planetRadiusInSun = new List<string>();
		private List<string> planetRadiusInSunUpperUncertainty = new List<string>();
		private List<string> planetRadiusInSunLowerUncertainty = new List<string>();
		private List<string> planetRadiusInSunLimitFlag = new List<string>();
		private List<string> planetTransitDepth = new List<string>();
		private List<string> planetTransitDepthUpperUncertainty = new List<string>();
		private List<string> planetTransitDepthLowerUncertainty = new List<string>();
		private List<string> planetTransitDepthLimitFlag = new List<string>();
		private List<string> planetTransitDuration = new List<string>();
		private List<string> planetTransitDurationUpperUncertainty = new List<string>();
		private List<string> planetTransitDurationLowerUncertainty = new List<string>();
		private List<string> planetTransitDurationLimitFlag = new List<string>();
		private List<string> planetTransitMidpoint = new List<string>();
		private List<string> planetTransitMidpointUpperUncertainty = new List<string>();
		private List<string> planetTransitMidpointLowerUncertainty = new List<string>();
		private List<string> planetTransitMidpointLimitFlag = new List<string>();
		private List<string> planetTimeSystemReference = new List<string>();
		private List<string> planetImpactParameter = new List<string>();
		private List<string> planetImpactParameterUpperUncertainty = new List<string>();
		private List<string> planetImpactParameterLowerUncertainty = new List<string>();
		private List<string> planetImpactParameterLimitFlag = new List<string>();
		private List<string> planetOccultationDepth = new List<string>();
		private List<string> planetOccultationDepthUpperUncertainty = new List<string>();
		private List<string> planetOccultationDepthLowerUncertainty = new List<string>();
		private List<string> planetOccultationDepthLimitFlag = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadius = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadiusUpperUncertainty = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadiusLowerUncertainty = new List<string>();
		private List<string> planetRatioOfDistanceToStellarRadiusLimitFlag = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadius = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadiusUpperUncertainty = new List<string>();
		private List<string> planetRatioOfPlanetToStellarRadiusLowerUncertainty = new List<string>();
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
		private List<string> hdName = new List<string>();
		private List<string> hipName = new List<string>();
		private List<string> starRectascension = new List<string>();
		private List<string> starGalacticLongitude = new List<string>();
		private List<string> starGalacticLatitude = new List<string>();
		private List<string> starEclipticLongitude = new List<string>();
		private List<string> starEclipticLatitude = new List<string>();
		private List<string> starParallax = new List<string>();
		private List<string> starParallaxUpperUncertainty = new List<string>();
		private List<string> starParallaxLowerUncertainty = new List<string>();
		private List<string> starParallaxLimitFlag = new List<string>();
		private List<string> gaiaParallax = new List<string>();
		private List<string> gaiaParallaxUpperUncertainty = new List<string>();
		private List<string> gaiaParallaxLowerUncertainty = new List<string>();
		private List<string> gaiaParallaxLimitFlag = new List<string>();
		private List<string> gaiaDistance = new List<string>();
		private List<string> gaiaDistanceUpperUncertainty = new List<string>();
		private List<string> gaiaDistanceLowerUncertainty = new List<string>();
		private List<string> gaiaDistanceLimitFlag = new List<string>();
		private List<string> starProperMotionByRectascension = new List<string>();
		private List<string> starProperMotionByRectascensionUncertainty = new List<string>();
		private List<string> starProperMotionByRectascensionLimitFlag = new List<string>();
		private List<string> starProperMotionByDeclination = new List<string>();
		private List<string> starProperMotionByDeclinationUncertainty = new List<string>();
		private List<string> starProperMotionByDeclinationLimitFlag = new List<string>();
		private List<string> starTotalProperMotion = new List<string>();
		private List<string> starTotalProperMotionUncertainty = new List<string>();
		private List<string> starTotalProperMotionLimitFlag = new List<string>();
		private List<string> gaiaProperMotionByRectascension = new List<string>();
		private List<string> gaiaProperMotionByRectascensionUncertainty = new List<string>();
		private List<string> gaiaProperMotionByRectascensionLimitFlag = new List<string>();
		private List<string> gaiaProperMotionByDeclination = new List<string>();
		private List<string> gaiaProperMotionByDeclinationUncertainty = new List<string>();
		private List<string> gaiaProperMotionByDeclinationLimitFlag = new List<string>();
		private List<string> gaiaTotalProperMotion = new List<string>();
		private List<string> gaiaTotalProperMotionUncertainty = new List<string>();
		private List<string> gaiaTotalProperMotionLimitFlag = new List<string>();
		private List<string> starRadialVelocity = new List<string>();
		private List<string> starRadialVelocityUpperUncertainty = new List<string>();
		private List<string> starRadialVelocityLowerUncertainty = new List<string>();
		private List<string> starRadialVelocityLimitFlag = new List<string>();
		private List<string> starSpectralType = new List<string>();
		private List<string> starSpectralTypeAsString = new List<string>();
		private List<string> starSpectralTypeUncertainty = new List<string>();
		private List<string> starSpectralTypeLimitFlag = new List<string>();
		private List<string> starSurfaceGravity = new List<string>();
		private List<string> starSurfaceGravityUpperUncertainty = new List<string>();
		private List<string> starSurfaceGravityLowerUncertainty = new List<string>();
		private List<string> starSurfaceGravityLimitFlag = new List<string>();
		private List<string> starLuminosity = new List<string>();
		private List<string> starLuminosityUpperUncertainty = new List<string>();
		private List<string> starLuminosityLowerUncertainty = new List<string>();
		private List<string> starLuminosityLimitFlag = new List<string>();
		private List<string> starDensity = new List<string>();
		private List<string> starDensityUpperUncertainty = new List<string>();
		private List<string> starDensityLowerUncertainty = new List<string>();
		private List<string> starDensityLimitFlag = new List<string>();
		private List<string> starMetalicity = new List<string>();
		private List<string> starMetalicityUpperUncertainty = new List<string>();
		private List<string> starMetalicityLowerUncertainty = new List<string>();
		private List<string> starMetalicityLimitFlag = new List<string>();
		private List<string> starMetalicityRatio = new List<string>();
		private List<string> starAge = new List<string>();
		private List<string> starAgeUpperUncertainty = new List<string>();
		private List<string> starAgeLowerUncertainty = new List<string>();
		private List<string> starAgeLimitFlag = new List<string>();
		private List<string> starRotationalVelocityVsini = new List<string>();
		private List<string> starRotationalVelocityVsiniUpperUncertainty = new List<string>();
		private List<string> starRotationalVelocityVsiniLowerUncertainty = new List<string>();
		private List<string> starRotationalVelocityVsiniLimitFlag = new List<string>();
		private List<string> starActivitySindex = new List<string>();
		private List<string> starActivitySindexUncertainty = new List<string>();
		private List<string> starActivitySindexLimitFlag = new List<string>();
		private List<string> starActivityLog = new List<string>();
		private List<string> starActivityLogUncertainty = new List<string>();
		private List<string> starActivityLogLimitFlag = new List<string>();
		private List<string> starXrayActivityLog = new List<string>();
		private List<string> starXrayActivityLogUncertainty = new List<string>();
		private List<string> starXrayActivityLogLimitFlag = new List<string>();
		private List<string> swaspIdentifier = new List<string>();
		private List<string> starNumerOfTimeSeries = new List<string>();
		private List<string> starNumerOfPlanetTransitLightCurves = new List<string>();
		private List<string> starNumerOfGeneralLightCurves = new List<string>();
		private List<string> starNumerOfRadialVelocityTimeSeries = new List<string>();
		private List<string> starNumerOfAmateurLightCurves = new List<string>();
		private List<string> starNumerOfImages = new List<string>();
		private List<string> starNumerOfSpectra = new List<string>();
		private List<string> starUBand = new List<string>();
		private List<string> starUBandUncertainty = new List<string>();
		private List<string> starUBandLimitFlag = new List<string>();
		private List<string> starVBand = new List<string>();
		private List<string> starVBandUncertainty = new List<string>();
		private List<string> starVBandLimitFlag = new List<string>();
		private List<string> starBBand = new List<string>();
		private List<string> starBBandUncertainty = new List<string>();
		private List<string> starBBandLimitFlag = new List<string>();
		private List<string> starRBand = new List<string>();
		private List<string> starRBandUncertainty = new List<string>();
		private List<string> starRBandLimitFlag = new List<string>();
		private List<string> starIBand = new List<string>();
		private List<string> starIBandUncertainty = new List<string>();
		private List<string> starIBandLimitFlag = new List<string>();
		private List<string> starJBand = new List<string>();
		private List<string> starJBandUncertainty = new List<string>();
		private List<string> starJBandLimitFlag = new List<string>();
		private List<string> starHBand = new List<string>();
		private List<string> starHBandUncertainty = new List<string>();
		private List<string> starHBandLimitFlag = new List<string>();
		private List<string> starKsBand = new List<string>();
		private List<string> starksBandUncertainty = new List<string>();
		private List<string> starKsBandLimitFlag = new List<string>();
		private List<string> starWise34um = new List<string>();
		private List<string> starWise34umUncertainty = new List<string>();
		private List<string> starWise34umLimitFlag = new List<string>();
		private List<string> starWise46um = new List<string>();
		private List<string> starWise46umUncertainty = new List<string>();
		private List<string> starWise46umLimitFlag = new List<string>();
		private List<string> starWise12um = new List<string>();
		private List<string> starWise12umUncertainty = new List<string>();
		private List<string> starWise12umLimitFlag = new List<string>();
		private List<string> starWise22um = new List<string>();
		private List<string> starWise22umUncertainty = new List<string>();
		private List<string> starWise22umLimitFlag = new List<string>();
		private List<string> starIrac36um = new List<string>();
		private List<string> starIrac36umUncertainty = new List<string>();
		private List<string> starIrac36umLimitFlag = new List<string>();
		private List<string> starIrac45um = new List<string>();
		private List<string> starIrac45umUncertainty = new List<string>();
		private List<string> starIrac45umLimitFlag = new List<string>();
		private List<string> starIrac58um = new List<string>();
		private List<string> starIrac58umUncertainty = new List<string>();
		private List<string> starIrac58umLimitFlag = new List<string>();
		private List<string> starIrac80um = new List<string>();
		private List<string> starIrac80umUncertainty = new List<string>();
		private List<string> starIrac80umLimitFlag = new List<string>();
		private List<string> starMips24um = new List<string>();
		private List<string> starMips24umUncertainty = new List<string>();
		private List<string> starMips24umLimitFlag = new List<string>();
		private List<string> starMips70um = new List<string>();
		private List<string> starMips70umUncertainty = new List<string>();
		private List<string> starMips70umLimitFlag = new List<string>();
		private List<string> starMips160um = new List<string>();
		private List<string> starMips160umUncertainty = new List<string>();
		private List<string> starMips160umLimitFlag = new List<string>();
		private List<string> starIras12um = new List<string>();
		private List<string> starIras12umUncertainty = new List<string>();
		private List<string> starIras12umLimitFlag = new List<string>();
		private List<string> starIras25um = new List<string>();
		private List<string> starIras25umUncertainty = new List<string>();
		private List<string> starIras25umLimitFlag = new List<string>();
		private List<string> starIras60um = new List<string>();
		private List<string> starIras60umUncertainty = new List<string>();
		private List<string> starIras60umLimitFlag = new List<string>();
		private List<string> starIras100um = new List<string>();
		private List<string> starIras100umUncertainty = new List<string>();
		private List<string> starIras100umLimitFlag = new List<string>();
		private List<string> starNumberOfPhotometryMeasurements = new List<string>();
		private List<string> starUbColorIndex = new List<string>();
		private List<string> starUbColorIndexUncertainty = new List<string>();
		private List<string> starUbColorIndexLimitFlag = new List<string>();
		private List<string> starBvColorIndex = new List<string>();
		private List<string> starBvColorIndexUncertainty = new List<string>();
		private List<string> starBvColorIndexLimitFlag = new List<string>();
		private List<string> starViColorIndex = new List<string>();
		private List<string> starViColorIndexUncertainty = new List<string>();
		private List<string> starViColorIndexLimitFlag = new List<string>();
		private List<string> starVrColorIndex = new List<string>();
		private List<string> starVrColorIndexUncertainty = new List<string>();
		private List<string> starVrColorIndexLimitFlag = new List<string>();
		private List<string> starJhColorIndex = new List<string>();
		private List<string> starJhColorIndexUncertainty = new List<string>();
		private List<string> starJhColorIndexLimitFlag = new List<string>();
		private List<string> starHksColorIndex = new List<string>();
		private List<string> starHksColorIndexUncertainty = new List<string>();
		private List<string> starHksColorIndexLimitFlag = new List<string>();
		private List<string> starJksColorIndex = new List<string>();
		private List<string> starJksColorIndexUncertainty = new List<string>();
		private List<string> starJksColorIndexLimitFlag = new List<string>();
		private List<string> starByColorIndex = new List<string>();
		private List<string> starByColorIndexUncertainty = new List<string>();
		private List<string> starByColorIndexLimitFlag = new List<string>();
		private List<string> starM1ColorIndex = new List<string>();
		private List<string> starM1ColorIndexUncertainty = new List<string>();
		private List<string> starM1ColorIndexLimitFlag = new List<string>();
		private List<string> starC1ColorIndex = new List<string>();
		private List<string> starC1ColorIndexUncertainty = new List<string>();
		private List<string> starC1ColorIndexLimitFlag = new List<string>();
		private List<string> starNumberOfColorMeasurements = new List<string>();

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
			planetOrbitalPeriodUpperUncertainty.Clear();
			planetOrbitalPeriodLowerUncertainty.Clear();
			planetOrbitalPeriodLimitFlag.Clear();
			planetSemiMajorAxis.Clear();
			planetSemiMajorAxisUpperUncertainty.Clear();
			planetSemiMajorAxisLowerUncertainty.Clear();
			planetSemiMajorAxisLimitFlag.Clear();
			planetNumericEccentricity.Clear();
			planetNumericEccentricityUpperUncertainty.Clear();
			planetNumericEccentricityUncertainty.Clear();
			planetNumericEccentricityLimitFlag.Clear();
			planetInclination.Clear();
			planetInclinationUpperUncertainty.Clear();
			planetInclinationLowerUncertainty.Clear();
			planetInclinationLimitFlag.Clear();
			planetPotentialMassInJupiter.Clear();
			planetPotentialMassInJupiterUpperUncertainty.Clear();
			planetPotentialMassInJupiterLowerUncertainty.Clear();
			planetPotentialMassInJupiterLimitFlag.Clear();
			planetPotentialMassProvenance.Clear();
			planetRadiusInJupiter.Clear();
			planetRadiusInJupiterUpperUncertainty.Clear();
			planetRadiusInJupiterLowerUncertainty.Clear();
			planetRadiusInJupiterLimitFlag.Clear();
			planetDensity.Clear();
			planetDensityUpperUncertainty.Clear();
			planetDensityLowerUncertainty.Clear();
			planetDensityLimitFlag.Clear();
			planetTtvFlag.Clear();
			planetKeplerFieldFlag.Clear();
			planetK2MissionFlag.Clear();
			planetNumberOfNotes.Clear();
			rectascension.Clear();
			rectascensionAsString.Clear();
			declination.Clear();
			declinationAsString.Clear();
			starDistance.Clear();
			starDistanceUpperUncertainty.Clear();
			starDistanceLowerUncertainty.Clear();
			starDistanceLimitFlag.Clear();
			starOpticalMagnitude.Clear();
			starOpticalMagnitudeUncertainty.Clear();
			starOpticalMagnitudeLimitFlag.Clear();
			starOpticalMagnitudeBand.Clear();
			gaiaGBand.Clear();
			gaiaGBandUncertainty.Clear();
			gaiaGBandLimitFlag.Clear();
			starEffectiveTemperature.Clear();
			starEffectiveTemperatureUpperUncertainty.Clear();
			starEffectiveTemperatureLowerUncertainty.Clear();
			starEffectiveTemperatureLimitFlag.Clear();
			starMass.Clear();
			starMassUpperUncertainty.Clear();
			starMassLowerUncertainty.Clear();
			starMassLimitFlag.Clear();
			starRadius.Clear();
			starRadiusUpperUncertainty.Clear();
			starRadiusLowerUncertainty.Clear();
			starRadiusLimitFlag.Clear();
			dateLastUpdate.Clear();
			planetTransitFlag.Clear();
			planetRadialVelocityFlag.Clear();
			planetImagingFlag.Clear();
			planetAstrometryFlag.Clear();
			planetOrbitalModulationFlag.Clear();
			planetCircumbinaryFlag.Clear();
			planetCalculatedAngularSeparation.Clear();
			planetCalculatedAngularSeparationUpperUncertainty.Clear();
			planetCalculatedAngularSeparationLowerUncertainty.Clear();
			planetTimeOfPeriastron.Clear();
			planetTimeOfPeriastronUpperUncertainty.Clear();
			planetTimeOfPeriastronLowerUncertainty.Clear();
			planetTimeOfPeriastronLimitFlag.Clear();
			planetLongitudeOfPeriastron.Clear();
			planetLongitudeOfPeriastronUpperUncertainty.Clear();
			planetLongitudeOfPeriastronLowerUncertainty.Clear();
			planetLongitudeOfPeriastronLimitFlag.Clear();
			planetRadialVelocityAmplitude.Clear();
			planetRadialVelocityAmplitudeUpperUncertainty.Clear();
			planetRadialVelocityAmplitudeLowerUncertainty.Clear();
			planetRadialVelocityAmplitudeLimitFlag.Clear();
			planetEquilibriumTemperature.Clear();
			planetEquilibriumTemperatureUpperUncertainty.Clear();
			planetEquilibriumTemperatureLowerUncertainty.Clear();
			planetEquilibriumTemperatureLimitFlag.Clear();
			planetInsolationFlux.Clear();
			planetInsolationFluxUpperUncertainty.Clear();
			planetInsolationFluxLowerUncertainty.Clear();
			planetInsolationFluxLimitFlag.Clear();
			planetMassInJupiter.Clear();
			planetMassInJupiterUpperUncertainty.Clear();
			planetMassInJupiterLowerUncertainty.Clear();
			planetMassInJupiterLimitFlag.Clear();
			planetMsiniInJupiter.Clear();
			planetMsiniInJupiterUpperUncertainty.Clear();
			planetMsiniInJupiterLowerUncertainty.Clear();
			planetMsiniInJupiterLimitFlag.Clear();
			planetMassInEarth.Clear();
			planetMassInEarthUpperUncertainty.Clear();
			planetMassInEarthLowerUncertainty.Clear();
			planetMassInEarthLimitFlag.Clear();
			planetMsiniInEarth.Clear();
			planetMsiniInEarthUpperUncertainty.Clear();
			planetMsiniInEarthLowerUncertainty.Clear();
			planetMsiniInEarthLimitFlag.Clear();
			planetPotentialMassInEarth.Clear();
			planetPotentialMassInEarthUpperUncertainty.Clear();
			planetPotentialMassInEarthLowerUncertainty.Clear();
			planetPotentialMassInEarthLimitFlag.Clear();
			planetRadiusInEarth.Clear();
			planetRadiusInEarthUpperUncertainty.Clear();
			planetRadiusInEarthLowerUncertainty.Clear();
			planetRadiusInEarthLimitFlag.Clear();
			planetRadiusInSun.Clear();
			planetRadiusInSunUpperUncertainty.Clear();
			planetRadiusInSunLowerUncertainty.Clear();
			planetRadiusInSunLimitFlag.Clear();
			planetTransitDepth.Clear();
			planetTransitDepthUpperUncertainty.Clear();
			planetTransitDepthLowerUncertainty.Clear();
			planetTransitDepthLimitFlag.Clear();
			planetTransitDuration.Clear();
			planetTransitDurationUpperUncertainty.Clear();
			planetTransitDurationLowerUncertainty.Clear();
			planetTransitDurationLimitFlag.Clear();
			planetTransitMidpoint.Clear();
			planetTransitMidpointUpperUncertainty.Clear();
			planetTransitMidpointLowerUncertainty.Clear();
			planetTransitMidpointLimitFlag.Clear();
			planetTimeSystemReference.Clear();
			planetImpactParameter.Clear();
			planetImpactParameterUpperUncertainty.Clear();
			planetImpactParameterLowerUncertainty.Clear();
			planetImpactParameterLimitFlag.Clear();
			planetOccultationDepth.Clear();
			planetOccultationDepthUpperUncertainty.Clear();
			planetOccultationDepthLowerUncertainty.Clear();
			planetOccultationDepthLimitFlag.Clear();
			planetRatioOfDistanceToStellarRadius.Clear();
			planetRatioOfDistanceToStellarRadiusUpperUncertainty.Clear();
			planetRatioOfDistanceToStellarRadiusLowerUncertainty.Clear();
			planetRatioOfDistanceToStellarRadiusLimitFlag.Clear();
			planetRatioOfPlanetToStellarRadius.Clear();
			planetRatioOfPlanetToStellarRadiusUpperUncertainty.Clear();
			planetRatioOfPlanetToStellarRadiusLowerUncertainty.Clear();
			planetRatioOfPlanetToStellarRadiusLimitFlag.Clear();
			planetDefaultReference.Clear();
			planetYearOfDiscovery.Clear();
			planetDiscoveryReference.Clear();
			planetDiscoveryLocale.Clear();
			planetDiscoveryFacility.Clear();
			planetDiscoveryTelescope.Clear();
			planeDiscoveryInstrument.Clear();
			planetStatus.Clear();
			planetNumberOfMoonsInSystem.Clear();
			planetNumberOfStellarAndPlanetParameters.Clear();
			planetNumberOfStellarAndPlanetReferences.Clear();
			planetLinkToExoplanetEncyclopaedia.Clear();
			planetLinkToExoplanetDataExplorer.Clear();
			planetPublicationDate.Clear();
			hdName.Clear();
			hipName.Clear();
			starRectascension.Clear();
			starGalacticLongitude.Clear();
			starGalacticLatitude.Clear();
			starEclipticLongitude.Clear();
			starEclipticLatitude.Clear();
			starParallax.Clear();
			starParallaxUpperUncertainty.Clear();
			starParallaxLowerUncertainty.Clear();
			starParallaxLimitFlag.Clear();
			gaiaParallax.Clear();
			gaiaParallaxUpperUncertainty.Clear();
			gaiaParallaxLowerUncertainty.Clear();
			gaiaParallaxLimitFlag.Clear();
			gaiaDistance.Clear();
			gaiaDistanceUpperUncertainty.Clear();
			gaiaDistanceLowerUncertainty.Clear();
			gaiaDistanceLimitFlag.Clear();
			starProperMotionByRectascension.Clear();
			starProperMotionByRectascensionUncertainty.Clear();
			starProperMotionByRectascensionLimitFlag.Clear();
			starProperMotionByDeclination.Clear();
			starProperMotionByDeclinationUncertainty.Clear();
			starProperMotionByDeclinationLimitFlag.Clear();
			starTotalProperMotion.Clear();
			starTotalProperMotionUncertainty.Clear();
			starTotalProperMotionLimitFlag.Clear();
			gaiaProperMotionByRectascension.Clear();
			gaiaProperMotionByRectascensionUncertainty.Clear();
			gaiaProperMotionByRectascensionLimitFlag.Clear();
			gaiaProperMotionByDeclination.Clear();
			gaiaProperMotionByDeclinationUncertainty.Clear();
			gaiaProperMotionByDeclinationLimitFlag.Clear();
			gaiaTotalProperMotion.Clear();
			gaiaTotalProperMotionUncertainty.Clear();
			gaiaTotalProperMotionLimitFlag.Clear();
			starRadialVelocity.Clear();
			starRadialVelocityUpperUncertainty.Clear();
			starRadialVelocityLowerUncertainty.Clear();
			starRadialVelocityLimitFlag.Clear();
			starSpectralType.Clear();
			starSpectralTypeAsString.Clear();
			starSpectralTypeUncertainty.Clear();
			starSpectralTypeLimitFlag.Clear();
			starSurfaceGravity.Clear();
			starSurfaceGravityUpperUncertainty.Clear();
			starSurfaceGravityLowerUncertainty.Clear();
			starSurfaceGravityLimitFlag.Clear();
			starLuminosity.Clear();
			starLuminosityUpperUncertainty.Clear();
			starLuminosityLowerUncertainty.Clear();
			starLuminosityLimitFlag.Clear();
			starDensity.Clear();
			starDensityUpperUncertainty.Clear();
			starDensityLowerUncertainty.Clear();
			starDensityLimitFlag.Clear();
			starMetalicity.Clear();
			starMetalicityUpperUncertainty.Clear();
			starMetalicityLowerUncertainty.Clear();
			starMetalicityLimitFlag.Clear();
			starMetalicityRatio.Clear();
			starAge.Clear();
			starAgeUpperUncertainty.Clear();
			starAgeLowerUncertainty.Clear();
			starAgeLimitFlag.Clear();
			starRotationalVelocityVsini.Clear();
			starRotationalVelocityVsiniUpperUncertainty.Clear();
			starRotationalVelocityVsiniLowerUncertainty.Clear();
			starRotationalVelocityVsiniLimitFlag.Clear();
			starActivitySindex.Clear();
			starActivitySindexUncertainty.Clear();
			starActivitySindexLimitFlag.Clear();
			starActivityLog.Clear();
			starActivityLogUncertainty.Clear();
			starActivityLogLimitFlag.Clear();
			starXrayActivityLog.Clear();
			starXrayActivityLogUncertainty.Clear();
			starXrayActivityLogLimitFlag.Clear();
			swaspIdentifier.Clear();
			starNumerOfTimeSeries.Clear();
			starNumerOfPlanetTransitLightCurves.Clear();
			starNumerOfGeneralLightCurves.Clear();
			starNumerOfRadialVelocityTimeSeries.Clear();
			starNumerOfAmateurLightCurves.Clear();
			starNumerOfImages.Clear();
			starNumerOfSpectra.Clear();
			starUBand.Clear();
			starUBandUncertainty.Clear();
			starUBandLimitFlag.Clear();
			starVBand.Clear();
			starVBandUncertainty.Clear();
			starVBandLimitFlag.Clear();
			starBBand.Clear();
			starBBandUncertainty.Clear();
			starBBandLimitFlag.Clear();
			starRBand.Clear();
			starRBandUncertainty.Clear();
			starRBandLimitFlag.Clear();
			starIBand.Clear();
			starIBandUncertainty.Clear();
			starIBandLimitFlag.Clear();
			starJBand.Clear();
			starJBandUncertainty.Clear();
			starJBandLimitFlag.Clear();
			starHBand.Clear();
			starHBandUncertainty.Clear();
			starHBandLimitFlag.Clear();
			starKsBand.Clear();
			starksBandUncertainty.Clear();
			starKsBandLimitFlag.Clear();
			starWise34um.Clear();
			starWise34umUncertainty.Clear();
			starWise34umLimitFlag.Clear();
			starWise46um.Clear();
			starWise46umUncertainty.Clear();
			starWise46umLimitFlag.Clear();
			starWise12um.Clear();
			starWise12umUncertainty.Clear();
			starWise12umLimitFlag.Clear();
			starWise22um.Clear();
			starWise22umUncertainty.Clear();
			starWise22umLimitFlag.Clear();
			starIrac36um.Clear();
			starIrac36umUncertainty.Clear();
			starIrac36umLimitFlag.Clear();
			starIrac45um.Clear();
			starIrac45umUncertainty.Clear();
			starIrac45umLimitFlag.Clear();
			starIrac58um.Clear();
			starIrac58umUncertainty.Clear();
			starIrac58umLimitFlag.Clear();
			starIrac80um.Clear();
			starIrac80umUncertainty.Clear();
			starIrac80umLimitFlag.Clear();
			starMips24um.Clear();
			starMips24umUncertainty.Clear();
			starMips24umLimitFlag.Clear();
			starMips70um.Clear();
			starMips70umUncertainty.Clear();
			starMips70umLimitFlag.Clear();
			starMips160um.Clear();
			starMips160umUncertainty.Clear();
			starMips160umLimitFlag.Clear();
			starIras12um.Clear();
			starIras12umUncertainty.Clear();
			starIras12umLimitFlag.Clear();
			starIras25um.Clear();
			starIras25umUncertainty.Clear();
			starIras25umLimitFlag.Clear();
			starIras60um.Clear();
			starIras60umUncertainty.Clear();
			starIras60umLimitFlag.Clear();
			starIras100um.Clear();
			starIras100umUncertainty.Clear();
			starIras100umLimitFlag.Clear();
			starNumberOfPhotometryMeasurements.Clear();
			starUbColorIndex.Clear();
			starUbColorIndexUncertainty.Clear();
			starUbColorIndexLimitFlag.Clear();
			starBvColorIndex.Clear();
			starBvColorIndexUncertainty.Clear();
			starBvColorIndexLimitFlag.Clear();
			starViColorIndex.Clear();
			starViColorIndexUncertainty.Clear();
			starViColorIndexLimitFlag.Clear();
			starVrColorIndex.Clear();
			starVrColorIndexUncertainty.Clear();
			starVrColorIndexLimitFlag.Clear();
			starJhColorIndex.Clear();
			starJhColorIndexUncertainty.Clear();
			starJhColorIndexLimitFlag.Clear();
			starHksColorIndex.Clear();
			starHksColorIndexUncertainty.Clear();
			starHksColorIndexLimitFlag.Clear();
			starJksColorIndex.Clear();
			starJksColorIndexUncertainty.Clear();
			starJksColorIndexLimitFlag.Clear();
			starByColorIndex.Clear();
			starByColorIndexUncertainty.Clear();
			starByColorIndexLimitFlag.Clear();
			starM1ColorIndex.Clear();
			starM1ColorIndexUncertainty.Clear();
			starM1ColorIndexLimitFlag.Clear();
			starC1ColorIndex.Clear();
			starC1ColorIndexUncertainty.Clear();
			starC1ColorIndexLimitFlag.Clear();
			starNumberOfColorMeasurements.Clear();
		}

		private void DisableAllControlsToLoadingDatabase()
		{
			toolStripMenuItemLoadInternalDatabase.Enabled = false;
			toolStripMenuItemLoadOnlineDatabase.Enabled = false;
			toolStripMenuItemLoadExternalDatabase.Enabled = false;
			toolStripButtonLoadInternalDatabase.Enabled = false;
			toolStripButtonLoadOnlineDatabase.Enabled = false;
			toolStripButtonLoadExternalDatabase.Enabled = false;
			kryptonButtonLoadInternalDatabase.Enabled = false;
			kryptonButtonLoadOnlineDatabase.Enabled = false;
			kryptonButtonLoadExternalDatabase.Enabled = false;
		}

		private void EnableAllControlsToLoadingDatabase()
		{
			toolStripMenuItemLoadInternalDatabase.Enabled = true;
			toolStripMenuItemLoadOnlineDatabase.Enabled = true;
			toolStripMenuItemLoadExternalDatabase.Enabled = true;
			toolStripButtonLoadInternalDatabase.Enabled = true;
			toolStripButtonLoadOnlineDatabase.Enabled = true;
			toolStripButtonLoadExternalDatabase.Enabled = true;
			kryptonButtonLoadInternalDatabase.Enabled = true;
			kryptonButtonLoadOnlineDatabase.Enabled = true;
			kryptonButtonLoadExternalDatabase.Enabled = true;
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
			else if (sender is ToolStripButton)
			{
				toolStripStatusLabel.Text = ((ToolStripButton)sender).AccessibleDescription;
			}
			else if (sender is ToolStripMenuItem)
			{
				toolStripStatusLabel.Text = ((ToolStripMenuItem)sender).AccessibleDescription;
			}
			else if (sender is ToolStripLabel)
			{
				toolStripStatusLabel.Text = ((ToolStripLabel)sender).AccessibleDescription;
			}
			else if (sender is ToolStripComboBox)
			{
				toolStripStatusLabel.Text = ((ToolStripComboBox)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDown)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDown)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDownButton)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDownButton)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDownItem)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDownItem)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDownMenu)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDownMenu)sender).AccessibleDescription;
			}
			else if (sender is ToolStripProgressBar)
			{
				toolStripStatusLabel.Text = ((ToolStripProgressBar)sender).AccessibleDescription;
			}
			else if (sender is ToolStripSplitButton)
			{
				toolStripStatusLabel.Text = ((ToolStripSplitButton)sender).AccessibleDescription;
			}
			else if (sender is ToolStripSeparator)
			{
				toolStripStatusLabel.Text = ((ToolStripSeparator)sender).AccessibleDescription;
			}
			else if (sender is ToolStripStatusLabel)
			{
				toolStripStatusLabel.Text = ((ToolStripStatusLabel)sender).AccessibleDescription;
			}
			else if (sender is ToolStripTextBox)
			{
				toolStripStatusLabel.Text = ((ToolStripTextBox)sender).AccessibleDescription;
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

		private void MainForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			kryptonWrapLabelStatusOfProgressingDatabase.Text = string.Empty;
			kryptonWrapLabelStatusOfProgressingDatabase.Hide();
			progressBarLoadingDatabase.Hide();
		}

		#region Click-Eventhandlers

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

		private void ToolStripButtonLoadInternalDatabase_Click(object sender, EventArgs e)
		{
			KryptonButtonLoadInternalDatabase_Click(sender: sender, e: e);
		}

		private void ToolStripButtonLoadOnlineDatabase_Click(object sender, EventArgs e)
		{
			KryptonButtonLoadOnlineDatabase_Click(sender: sender, e: e);
		}

		private void ToolStripButtonLoadExternalDatabase_Click(object sender, EventArgs e)
		{
			KryptonButtonLoadExternalDatabase_Click(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadInternalDatabase_Click(object sender, EventArgs e)
		{
			KryptonButtonLoadInternalDatabase_Click(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadOnlineDatabase_Click(object sender, EventArgs e)
		{
			KryptonButtonLoadOnlineDatabase_Click(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadExternalDatabase_Click(object sender, EventArgs e)
		{
			KryptonButtonLoadExternalDatabase_Click(sender: sender, e: e);
		}

		private void ToolStripMenuItemOpenHomepage_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(fileName: "https://exo-db.de");
		}

		private void ToolStripMenuItemOpenGithub_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(fileName: "https://github.com/mjohne/EXO-DB");
		}

		private void KryptonButtonLoadInternalDatabase_Click(object sender, EventArgs e)
		{
			ClearAllLists();
			DisableAllControlsToLoadingDatabase();

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
						switch (headers[i])
						{
							case "pl_hostname": planetHostname.Add(item: csv[i]); break;
							case "pl_letter": planetLetter.Add(item: csv[i]); break;
							case "pl_name": planetName.Add(item: csv[i]); break;
							case "pl_discmethod": planetDiscoveryMethod.Add(item: csv[i]); break;
							case "pl_controvflag": planetControversialFlag.Add(item: csv[i]); break;
							case "pl_pnum": planetNumberofPlanets.Add(item: csv[i]); break;
							case "pl_orbper": planetOrbitalPeriod.Add(item: csv[i]); break;
							case "pl_orbpererr1": planetOrbitalPeriodUpperUncertainty.Add(item: csv[i]); break;
							case "pl_orbpererr2": planetOrbitalPeriodLowerUncertainty.Add(item: csv[i]); break;
							case "pl_orbperlim": planetOrbitalPeriodLimitFlag.Add(item: csv[i]); break;
							case "pl_orbsmax": planetSemiMajorAxis.Add(item: csv[i]); break;
							case "pl_orbsmaxerr1": planetSemiMajorAxisUpperUncertainty.Add(item: csv[i]); break;
							case "pl_orbsmaxerr2": planetSemiMajorAxisLowerUncertainty.Add(item: csv[i]); break;
							case "pl_orbsmaxlim": planetSemiMajorAxisLimitFlag.Add(item: csv[i]); break;
							case "pl_orbeccen": planetNumericEccentricity.Add(item: csv[i]); break;
							case "pl_orbeccenerr1": planetNumericEccentricityUpperUncertainty.Add(item: csv[i]); break;
							case "pl_orbeccenerr2": planetNumericEccentricityUncertainty.Add(item: csv[i]); break;
							case "pl_orbeccenlim": planetNumericEccentricityLimitFlag.Add(item: csv[i]); break;
							case "pl_orbincl": planetInclination.Add(item: csv[i]); break;
							case "pl_orbinclerr1": planetInclinationUpperUncertainty.Add(item: csv[i]); break;
							case "pl_orbinclerr2": planetInclinationLowerUncertainty.Add(item: csv[i]); break;
							case "pl_orbincllim": planetInclinationLimitFlag.Add(item: csv[i]); break;
							case "pl_bmassj": planetPotentialMassInJupiter.Add(item: csv[i]); break;
							case "pl_bmassjerr1": planetPotentialMassInJupiterUpperUncertainty.Add(item: csv[i]); break;
							case "pl_bmassjerr2": planetPotentialMassInJupiterLowerUncertainty.Add(item: csv[i]); break;
							case "pl_bmassjlim": planetPotentialMassInJupiterLimitFlag.Add(item: csv[i]); break;
							case "pl_bmassprov": planetPotentialMassProvenance.Add(item: csv[i]); break;
							case "pl_radj": planetRadiusInJupiter.Add(item: csv[i]); break;
							case "pl_radjerr1": planetRadiusInJupiterUpperUncertainty.Add(item: csv[i]); break;
							case "pl_radjerr2": planetRadiusInJupiterLowerUncertainty.Add(item: csv[i]); break;
							case "pl_radjlim": planetRadiusInJupiterLimitFlag.Add(item: csv[i]); break;
							case "pl_dens": planetDensity.Add(item: csv[i]); break;
							case "pl_denserr1": planetDensityUpperUncertainty.Add(item: csv[i]); break;
							case "pl_denserr2": planetDensityLowerUncertainty.Add(item: csv[i]); break;
							case "pl_denslim": planetDensityLimitFlag.Add(item: csv[i]); break;
							case "pl_ttvflag": planetTtvFlag.Add(item: csv[i]); break;
							case "pl_kepflag": planetKeplerFieldFlag.Add(item: csv[i]); break;
							case "pl_k2flag": planetK2MissionFlag.Add(item: csv[i]); break;
							case "pl_nnotes":	planetNumberOfNotes.Add(item: csv[i]); break;
							case "ra_str": rectascension.Add(item: csv[i]); break;
							case "ra": rectascensionAsString.Add(item: csv[i]); break;
							case "dec_str": declination.Add(item: csv[i]); break;
							case "dec": declinationAsString.Add(item: csv[i]); break;
							case "st_dist": starDistance.Add(item: csv[i]); break;
							case "st_disterr1": starDistanceUpperUncertainty.Add(item: csv[i]); break;
							case "st_disterr2": starDistanceLowerUncertainty.Add(item: csv[i]); break;
							case "st_distlim": starDistanceLimitFlag.Add(item: csv[i]); break;
							case "st_optmag": starOpticalMagnitude.Add(item: csv[i]); break;
							case "st_optmagerr": starOpticalMagnitudeUncertainty.Add(item: csv[i]); break;
							case "st_optmaglim": starOpticalMagnitudeLimitFlag.Add(item: csv[i]); break;
							case "st_optband": starOpticalMagnitudeBand.Add(item: csv[i]); break;
							case "gaia_gmag": gaiaGBand.Add(item: csv[i]); break;
							case "gaia_gmagerr": gaiaGBandUncertainty.Add(item: csv[i]); break;
							case "gaia_gmaglim": gaiaGBandLimitFlag.Add(item: csv[i]); break;
							case "st_teff": starEffectiveTemperature.Add(item: csv[i]); break;
							case "st_tefferr1": starEffectiveTemperatureUpperUncertainty.Add(item: csv[i]); break;
							case "st_tefferr2": starEffectiveTemperatureLowerUncertainty.Add(item: csv[i]); break;
							case "st_tefflim": starEffectiveTemperatureLimitFlag.Add(item: csv[i]); break;
							case "st_mass": starMass.Add(item: csv[i]); break;
							case "st_masserr1": starMassUpperUncertainty.Add(item: csv[i]); break;
							case "st_masserr2": starMassLowerUncertainty.Add(item: csv[i]); break;
							case "st_masslim": starMassLimitFlag.Add(item: csv[i]); break;
							case "st_rad": starMassLimitFlag.Add(item: csv[i]); break;
							case "st_raderr1": starRadiusUpperUncertainty.Add(item: csv[i]); break;
							case "st_raderr2": starRadiusLowerUncertainty.Add(item: csv[i]); break;
							case "st_radlim": starRadiusLimitFlag.Add(item: csv[i]); break;
							case "rowupdate": dateLastUpdate.Add(item: csv[i]); break;
							case "pl_tranflag": planetTransitFlag.Add(item: csv[i]); break;
							case "pl_rvflag": planetRadialVelocityFlag.Add(item: csv[i]); break;
							case "pl_imgflag": planetImagingFlag.Add(item: csv[i]); break;
							case "pl_astflag": planetAstrometryFlag.Add(item: csv[i]); break;
							case "pl_omflag": planetOrbitalModulationFlag.Add(item: csv[i]); break;
							case "pl_cbflag": planetCircumbinaryFlag.Add(item: csv[i]); break;
							case "pl_angsep": planetCalculatedAngularSeparation.Add(item: csv[i]); break;
							case "pl_angseperr1": planetCalculatedAngularSeparationUpperUncertainty.Add(item: csv[i]); break;
							case "pl_angseperr2": planetCalculatedAngularSeparationLowerUncertainty.Add(item: csv[i]); break;
							case "pl_orbtper": planetTimeOfPeriastron.Add(item: csv[i]); break;
							case "pl_orbtpererr1": planetTimeOfPeriastronUpperUncertainty.Add(item: csv[i]); break;
							case "pl_orbtpererr2": planetTimeOfPeriastronLowerUncertainty.Add(item: csv[i]); break;
							case "pl_orbtperlim": planetTimeOfPeriastronLimitFlag.Add(item: csv[i]); break;
							case "pl_orblper": planetLongitudeOfPeriastron.Add(item: csv[i]); break;
							case "pl_orblpererr1": planetLongitudeOfPeriastronUpperUncertainty.Add(item: csv[i]); break;
							case "pl_orblpererr2": planetLongitudeOfPeriastronLowerUncertainty.Add(item: csv[i]); break;
							case "pl_orblperlim": planetLongitudeOfPeriastronLimitFlag.Add(item: csv[i]); break;
							case "pl_rvamp": planetRadialVelocityAmplitude.Add(item: csv[i]); break;
							case "pl_rvamperr1": planetRadialVelocityAmplitudeUpperUncertainty.Add(item: csv[i]); break;
							case "pl_rvamperr2": planetRadialVelocityAmplitudeLowerUncertainty.Add(item: csv[i]); break;
							case "pl_rvamplim": planetRadialVelocityAmplitudeLimitFlag.Add(item: csv[i]); break;
							case "pl_eqt": planetEquilibriumTemperature.Add(item: csv[i]); break;
							case "pl_eqterr1": planetEquilibriumTemperatureUpperUncertainty.Add(item: csv[i]); break;
							case "pl_eqterr2": planetEquilibriumTemperatureLowerUncertainty.Add(item: csv[i]); break;
							case "pl_eqtlim": planetEquilibriumTemperatureLimitFlag.Add(item: csv[i]); break;
							case "pl_insol": planetInsolationFlux.Add(item: csv[i]); break;
							case "pl_insolerr1": planetInsolationFluxUpperUncertainty.Add(item: csv[i]); break;
							case "pl_insolerr2": planetInsolationFluxLowerUncertainty.Add(item: csv[i]); break;
							case "pl_insollim": planetInsolationFluxLimitFlag.Add(item: csv[i]); break;
							case "pl_massj": planetMassInJupiter.Add(item: csv[i]); break;
							case "pl_massjerr1": planetMassInJupiterUpperUncertainty.Add(item: csv[i]); break;
							case "pl_massjerr2": planetMassInJupiterLowerUncertainty.Add(item: csv[i]); break;
							case "pl_massjlim": planetMassInJupiterLimitFlag.Add(item: csv[i]); break;
							case "pl_msinij": planetMsiniInJupiter.Add(item: csv[i]); break;
							case "pl_msinijerr1": planetMsiniInJupiterUpperUncertainty.Add(item: csv[i]); break;
							case "pl_msinijerr2": planetMsiniInJupiterLowerUncertainty.Add(item: csv[i]); break;
							case "pl_msinijlim": planetMsiniInJupiterLimitFlag.Add(item: csv[i]); break;
							case "pl_masse": planetMassInEarth.Add(item: csv[i]); break;
							case "pl_masseerr1": planetMassInEarthUpperUncertainty.Add(item: csv[i]); break;
							case "pl_masseerr2": planetMassInEarthLowerUncertainty.Add(item: csv[i]); break;
							case "pl_masselim": planetMassInEarthLimitFlag.Add(item: csv[i]); break;
							case "pl_msinie": planetMsiniInEarth.Add(item: csv[i]); break;
							case "pl_msinieerr1": planetMsiniInEarthUpperUncertainty.Add(item: csv[i]); break;
							case "pl_msinieerr2": planetMsiniInEarthLowerUncertainty.Add(item: csv[i]); break;
							case "pl_msinielim": planetMsiniInEarthLimitFlag.Add(item: csv[i]); break;
							case "pl_bmasse": planetPotentialMassInEarth.Add(item: csv[i]); break;
							case "pl_bmasseerr1": planetPotentialMassInEarthUpperUncertainty.Add(item: csv[i]); break;
							case "pl_bmasseerr2": planetPotentialMassInEarthLowerUncertainty.Add(item: csv[i]); break;
							case "pl_bmasselim": planetPotentialMassInEarthLimitFlag.Add(item: csv[i]); break;
							case "pl_rade": planetRadiusInEarth.Add(item: csv[i]); break;
							case "pl_radeerr1": planetRadiusInEarthUpperUncertainty.Add(item: csv[i]); break;
							case "pl_radeerr2": planetRadiusInEarthLowerUncertainty.Add(item: csv[i]); break;
							case "pl_radelim": planetRadiusInEarthLimitFlag.Add(item: csv[i]); break;
							case "pl_rads": planetRadiusInSun.Add(item: csv[i]); break;
							case "pl_radserr1": planetRadiusInSunUpperUncertainty.Add(item: csv[i]); break;
							case "pl_radserr2": planetRadiusInSunLowerUncertainty.Add(item: csv[i]); break;
							case "pl_radslim": planetRadiusInSunLimitFlag.Add(item: csv[i]); break;
							case "pl_trandep": planetTransitDepth.Add(item: csv[i]); break;
							case "pl_trandeperr1": planetTransitDepthUpperUncertainty.Add(item: csv[i]); break;
							case "pl_trandeperr2": planetTransitDepthLowerUncertainty.Add(item: csv[i]); break;
							case "pl_trandeplim": planetTransitDepthLimitFlag.Add(item: csv[i]); break;
							case "pl_trandur": planetTransitDuration.Add(item: csv[i]); break;
							case "pl_trandurerr1": planetTransitDurationUpperUncertainty.Add(item: csv[i]); break;
							case "pl_trandurerr2": planetTransitDurationLowerUncertainty.Add(item: csv[i]); break;
							case "pl_trandurlim": planetTransitDurationLimitFlag.Add(item: csv[i]); break;
							case "pl_tranmid": planetTransitMidpoint.Add(item: csv[i]); break;
							case "pl_tranmiderr1": planetTransitMidpointUpperUncertainty.Add(item: csv[i]); break;
							case "pl_tranmiderr2": planetTransitMidpointLowerUncertainty.Add(item: csv[i]); break;
							case "pl_tranmidlim": planetTransitMidpointLimitFlag.Add(item: csv[i]); break;
							case "pl_tsystemref": planetTimeSystemReference.Add(item: csv[i]); break;
							case "pl_imppar": planetImpactParameter.Add(item: csv[i]); break;
							case "pl_impparerr1": planetImpactParameterUpperUncertainty.Add(item: csv[i]); break;
							case "pl_impparerr2": planetImpactParameterLowerUncertainty.Add(item: csv[i]); break;
							case "pl_impparlim": planetImpactParameterLimitFlag.Add(item: csv[i]); break;
							case "pl_occdep": planetOccultationDepth.Add(item: csv[i]); break;
							case "pl_occdeperr1": planetOccultationDepthUpperUncertainty.Add(item: csv[i]); break;
							case "pl_occdeperr2": planetOccultationDepthLowerUncertainty.Add(item: csv[i]); break;
							case "pl_occdeplim": planetOccultationDepthLimitFlag.Add(item: csv[i]); break;
							case "pl_ratdor": planetRatioOfDistanceToStellarRadius.Add(item: csv[i]); break;
							case "pl_ratdorerr1": planetRatioOfDistanceToStellarRadiusUpperUncertainty.Add(item: csv[i]); break;
							case "pl_ratdorerr2": planetRatioOfDistanceToStellarRadiusLowerUncertainty.Add(item: csv[i]); break;
							case "pl_ratdorlim": planetRatioOfDistanceToStellarRadiusLimitFlag.Add(item: csv[i]); break;
							case "pl_ratror": planetRatioOfPlanetToStellarRadius.Add(item: csv[i]); break;
							case "pl_ratrorerr1": planetRatioOfPlanetToStellarRadiusUpperUncertainty.Add(item: csv[i]); break;
							case "pl_ratrorerr2": planetRatioOfPlanetToStellarRadiusLowerUncertainty.Add(item: csv[i]); break;
							case "pl_ratrorlim": planetRatioOfPlanetToStellarRadiusLimitFlag.Add(item: csv[i]); break;
							case "pl_def_reflink": planetDefaultReference.Add(item: csv[i]); break;
							case "pl_disc": planetYearOfDiscovery.Add(item: csv[i]); break;
							case "pl_disc_reflink": planetDiscoveryReference.Add(item: csv[i]); break;
							case "pl_locale": planetDiscoveryLocale.Add(item: csv[i]); break;
							case "pl_facility": planetDiscoveryFacility.Add(item: csv[i]); break;
							case "pl_telescope": planetDiscoveryTelescope.Add(item: csv[i]); break;
							case "pl_instrument": planeDiscoveryInstrument.Add(item: csv[i]); break;
							case "pl_status": planetStatus.Add(item: csv[i]); break;
							case "pl_mnum": planetNumberOfMoonsInSystem.Add(item: csv[i]); break;
							case "pl_st_npar": planetNumberOfStellarAndPlanetParameters.Add(item: csv[i]); break;
							case "pl_st_nref": planetNumberOfStellarAndPlanetReferences.Add(item: csv[i]); break;
							case "pl_pelink": planetLinkToExoplanetEncyclopaedia.Add(item: csv[i]); break;
							case "pl_edelink": planetLinkToExoplanetDataExplorer.Add(item: csv[i]); break;
							case "pl_publ_date": planetPublicationDate.Add(item: csv[i]); break;
							case "hd_name": hdName.Add(item: csv[i]); break;
							case "hip_name": hipName.Add(item: csv[i]); break;
							case "st_rah": starRectascension.Add(item: csv[i]); break;
							case "st_glon": starGalacticLongitude.Add(item: csv[i]); break;
							case "st_glat": starGalacticLatitude.Add(item: csv[i]); break;
							case "st_elon": starEclipticLongitude.Add(item: csv[i]); break;
							case "st_elat": starEclipticLatitude.Add(item: csv[i]); break;
							case "st_plx": starParallax.Add(item: csv[i]); break;
							case "st_plxerr1": starParallaxUpperUncertainty.Add(item: csv[i]); break;
							case "st_plxerr2": starParallaxLowerUncertainty.Add(item: csv[i]); break;
							case "st_plxlim": starParallaxLimitFlag.Add(item: csv[i]); break;
							case "gaia_plx": gaiaParallax.Add(item: csv[i]); break;
							case "gaia_plxerr1": gaiaParallaxUpperUncertainty.Add(item: csv[i]); break;
							case "gaia_plxerr2": gaiaParallaxLowerUncertainty.Add(item: csv[i]); break;
							case "gaia_plxlim": gaiaParallaxLimitFlag.Add(item: csv[i]); break;
							case "gaia_dist": gaiaDistance.Add(item: csv[i]); break;
							case "gaia_disterr1": gaiaDistanceUpperUncertainty.Add(item: csv[i]); break;
							case "gaia_disterr2": gaiaDistanceLowerUncertainty.Add(item: csv[i]); break;
							case "gaia_distlim": gaiaDistanceLimitFlag.Add(item: csv[i]); break;
							case "st_pmra": starProperMotionByRectascension.Add(item: csv[i]); break;
							case "st_pmraerr": starProperMotionByRectascensionUncertainty.Add(item: csv[i]); break;
							case "st_pmralim": starProperMotionByRectascensionLimitFlag.Add(item: csv[i]); break;
							case "st_pmdec": starProperMotionByDeclination.Add(item: csv[i]); break;
							case "st_pmdecerr": starProperMotionByDeclinationUncertainty.Add(item: csv[i]); break;
							case "st_pmdeclim": starProperMotionByDeclinationLimitFlag.Add(item: csv[i]); break;
							case "st_pm": starTotalProperMotion.Add(item: csv[i]); break;
							case "st_pmerr": starTotalProperMotionUncertainty.Add(item: csv[i]); break;
							case "st_pmlim": starTotalProperMotionLimitFlag.Add(item: csv[i]); break;
							case "gaia_pmra": gaiaProperMotionByRectascension.Add(item: csv[i]); break;
							case "gaia_pmraerr": gaiaProperMotionByRectascensionUncertainty.Add(item: csv[i]); break;
							case "gaia_pmralim": gaiaProperMotionByRectascensionLimitFlag.Add(item: csv[i]); break;
							case "gaia_pmdec": gaiaProperMotionByDeclination.Add(item: csv[i]); break;
							case "gaia_pmdecerr": gaiaProperMotionByDeclinationUncertainty.Add(item: csv[i]); break;
							case "gaia_pmdeclim": gaiaProperMotionByDeclinationLimitFlag.Add(item: csv[i]); break;
							case "gaia_pm": gaiaTotalProperMotion.Add(item: csv[i]); break;
							case "gaia_pmerr": gaiaTotalProperMotionUncertainty.Add(item: csv[i]); break;
							case "gaia_pmlim": gaiaTotalProperMotionLimitFlag.Add(item: csv[i]); break;
							case "st_radv": starRadialVelocity.Add(item: csv[i]); break;
							case "st_radverr1": starRadialVelocityUpperUncertainty.Add(item: csv[i]); break;
							case "st_radverr2": starRadialVelocityLowerUncertainty.Add(item: csv[i]); break;
							case "st_radvlim": starRadialVelocityLimitFlag.Add(item: csv[i]); break;
							case "st_sp": starSpectralType.Add(item: csv[i]); break;
							case "st_spstr": starSpectralTypeAsString.Add(item: csv[i]); break;
							case "st_sperr": starSpectralTypeUncertainty.Add(item: csv[i]); break;
							case "st_splim": starSpectralTypeLimitFlag.Add(item: csv[i]); break;
							case "st_logg": starSurfaceGravity.Add(item: csv[i]); break;
							case "st_loggerr1": starSurfaceGravityUpperUncertainty.Add(item: csv[i]); break;
							case "st_loggerr2": starSurfaceGravityLowerUncertainty.Add(item: csv[i]); break;
							case "st_logglim": starSurfaceGravityLimitFlag.Add(item: csv[i]); break;
							case "st_lum": starLuminosity.Add(item: csv[i]); break;
							case "st_lumerr1": starLuminosityUpperUncertainty.Add(item: csv[i]); break;
							case "st_lumerr2": starLuminosityLowerUncertainty.Add(item: csv[i]); break;
							case "st_lumlim": starLuminosityLimitFlag.Add(item: csv[i]); break;
							case "st_dens": starDensity.Add(item: csv[i]); break;
							case "st_denserr1": starDensityUpperUncertainty.Add(item: csv[i]); break;
							case "st_denserr2": starDensityLowerUncertainty.Add(item: csv[i]); break;
							case "st_denslim": starDensityLimitFlag.Add(item: csv[i]); break;
							case "st_metfe": starMetalicity.Add(item: csv[i]); break;
							case "st_metfeerr1": starMetalicityUpperUncertainty.Add(item: csv[i]); break;
							case "st_metfeerr2": starMetalicityLowerUncertainty.Add(item: csv[i]); break;
							case "st_metfelim": starMetalicityLimitFlag.Add(item: csv[i]); break;
							case "st_metratio": starMetalicityRatio.Add(item: csv[i]); break;
							case "st_age": starAge.Add(item: csv[i]); break;
							case "st_ageerr1": starAgeUpperUncertainty.Add(item: csv[i]); break;
							case "st_ageerr2": starAgeLowerUncertainty.Add(item: csv[i]); break;
							case "st_agelim": starAgeLimitFlag.Add(item: csv[i]); break;
							case "st_vsini": starRotationalVelocityVsini.Add(item: csv[i]); break;
							case "st_vsinierr1": starRotationalVelocityVsiniUpperUncertainty.Add(item: csv[i]); break;
							case "st_vsinierr2": starRotationalVelocityVsiniLowerUncertainty.Add(item: csv[i]); break;
							case "st_vsinilim": starRotationalVelocityVsiniLimitFlag.Add(item: csv[i]); break;
							case "st_acts": starActivitySindex.Add(item: csv[i]); break;
							case "st_actserr": starActivitySindexUncertainty.Add(item: csv[i]); break;
							case "st_actslim": starActivitySindexLimitFlag.Add(item: csv[i]); break;
							case "st_actr": starActivityLog.Add(item: csv[i]); break;
							case "st_actrerr": starActivityLogUncertainty.Add(item: csv[i]); break;
							case "st_actrlim": starActivityLogLimitFlag.Add(item: csv[i]); break;
							case "st_actlx": starXrayActivityLog.Add(item: csv[i]); break;
							case "st_actlxerr": starXrayActivityLogUncertainty.Add(item: csv[i]); break;
							case "st_actlxlim": starXrayActivityLogLimitFlag.Add(item: csv[i]); break;
							case "swasp_id": swaspIdentifier.Add(item: csv[i]); break;
							case "st_nts": starNumerOfTimeSeries.Add(item: csv[i]); break;
							case "st_nplc": starNumerOfPlanetTransitLightCurves.Add(item: csv[i]); break;
							case "st_nglc": starNumerOfGeneralLightCurves.Add(item: csv[i]); break;
							case "st_nrvc": starNumerOfRadialVelocityTimeSeries.Add(item: csv[i]); break;
							case "st_naxa": starNumerOfAmateurLightCurves.Add(item: csv[i]); break;
							case "st_nimg": starNumerOfImages.Add(item: csv[i]); break;
							case "st_nspec": starNumerOfSpectra.Add(item: csv[i]); break;
							case "st_uj": starUBand.Add(item: csv[i]); break;
							case "st_ujerr": starUBandUncertainty.Add(item: csv[i]); break;
							case "st_ujlim": starUBandLimitFlag.Add(item: csv[i]); break;
							case "st_vj": starVBand.Add(item: csv[i]); break;
							case "st_vjerr": starVBandUncertainty.Add(item: csv[i]); break;
							case "st_vjlim": starVBandLimitFlag.Add(item: csv[i]); break;
							case "st_bj": starBBand.Add(item: csv[i]); break;
							case "st_bjerr": starBBandUncertainty.Add(item: csv[i]); break;
							case "st_bjlim": starBBandLimitFlag.Add(item: csv[i]); break;
							case "st_rc": starRBand.Add(item: csv[i]); break;
							case "st_rcerr": starRBandUncertainty.Add(item: csv[i]); break;
							case "st_rclim": starRBandLimitFlag.Add(item: csv[i]); break;
							case "st_ic": starIBand.Add(item: csv[i]); break;
							case "st_icerr": starIBandUncertainty.Add(item: csv[i]); break;
							case "st_iclim": starIBandLimitFlag.Add(item: csv[i]); break;
							case "st_j": starJBand.Add(item: csv[i]); break;
							case "st_jerr": starJBandUncertainty.Add(item: csv[i]); break;
							case "st_jlim": starJBandLimitFlag.Add(item: csv[i]); break;
							case "st_h": starHBand.Add(item: csv[i]); break;
							case "st_herr": starHBandUncertainty.Add(item: csv[i]); break;
							case "st_hlim": starHBandLimitFlag.Add(item: csv[i]); break;
							case "st_k": starKsBand.Add(item: csv[i]); break;
							case "st_kerr": starksBandUncertainty.Add(item: csv[i]); break;
							case "st_klim": starKsBandLimitFlag.Add(item: csv[i]); break;
							case "st_wise1": starWise34um.Add(item: csv[i]); break;
							case "st_wise1err": starWise34umUncertainty.Add(item: csv[i]); break;
							case "st_wise1lim": starWise34umLimitFlag.Add(item: csv[i]); break;
							case "st_wise2": starWise46um.Add(item: csv[i]); break;
							case "st_wise2err": starWise46umUncertainty.Add(item: csv[i]); break;
							case "st_wise2lim": starWise46umLimitFlag.Add(item: csv[i]); break;
							case "st_wise3": starWise12um.Add(item: csv[i]); break;
							case "st_wise3err": starWise12umUncertainty.Add(item: csv[i]); break;
							case "st_wise3lim": starWise12umLimitFlag.Add(item: csv[i]); break;
							case "st_wise4": starWise22um.Add(item: csv[i]); break;
							case "st_wise4err": starWise22umUncertainty.Add(item: csv[i]); break;
							case "st_wise4lim": starWise22umLimitFlag.Add(item: csv[i]); break;
							case "st_irac1": starIrac36um.Add(item: csv[i]); break;
							case "st_irac1err": starIrac36umUncertainty.Add(item: csv[i]); break;
							case "st_irac1lim": starIrac36umLimitFlag.Add(item: csv[i]); break;
							case "st_irac2": starIrac45um.Add(item: csv[i]); break;
							case "st_irac2err": starIrac45umUncertainty.Add(item: csv[i]); break;
							case "st_irac2lim": starIrac45umLimitFlag.Add(item: csv[i]); break;
							case "st_irac3": starIrac58um.Add(item: csv[i]); break;
							case "st_irac3err": starIrac58umUncertainty.Add(item: csv[i]); break;
							case "st_irac3lim": starIrac58umLimitFlag.Add(item: csv[i]); break;
							case "st_irac4": starIrac80um.Add(item: csv[i]); break;
							case "st_irac4err": starIrac80umUncertainty.Add(item: csv[i]); break;
							case "st_irac4lim": starIrac80umLimitFlag.Add(item: csv[i]); break;
							case "st_mips1": starMips24um.Add(item: csv[i]); break;
							case "st_mips1err": starMips24umUncertainty.Add(item: csv[i]); break;
							case "st_mips1lim": starMips24umLimitFlag.Add(item: csv[i]); break;
							case "st_mips2": starMips70um.Add(item: csv[i]); break;
							case "st_mips2err": starMips70umUncertainty.Add(item: csv[i]); break;
							case "st_mips2lim": starMips70umLimitFlag.Add(item: csv[i]); break;
							case "st_mips3": starMips160um.Add(item: csv[i]); break;
							case "st_mips3err": starMips160umUncertainty.Add(item: csv[i]); break;
							case "st_mips3lim": starMips160umLimitFlag.Add(item: csv[i]); break;
							case "st_iras1": starIras12um.Add(item: csv[i]); break;
							case "st_iras1err": starIras12umUncertainty.Add(item: csv[i]); break;
							case "st_iras1lim": starIras12umLimitFlag.Add(item: csv[i]); break;
							case "st_iras2": starIras25um.Add(item: csv[i]); break;
							case "st_iras2err": starIras25umUncertainty.Add(item: csv[i]); break;
							case "st_iras2lim": starIras25umLimitFlag.Add(item: csv[i]); break;
							case "st_iras3": starIras60um.Add(item: csv[i]); break;
							case "st_iras3err": starIras60umUncertainty.Add(item: csv[i]); break;
							case "st_iras3lim": starIras60umLimitFlag.Add(item: csv[i]); break;
							case "st_iras4": starIras100um.Add(item: csv[i]); break;
							case "st_iras4err": starIras100umUncertainty.Add(item: csv[i]); break;
							case "st_iras4lim": starIras100umLimitFlag.Add(item: csv[i]); break;
							case "st_photn": starNumberOfPhotometryMeasurements.Add(item: csv[i]); break;
							case "st_umbj": starUbColorIndex.Add(item: csv[i]); break;
							case "st_umbjerr": starUbColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_umbjlim": starUbColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_bmvj": starBvColorIndex.Add(item: csv[i]); break;
							case "st_bmvjerr": starBvColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_bmvjlim": starBvColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_vjmic": starViColorIndex.Add(item: csv[i]); break;
							case "st_vjmicerr": starViColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_vjmiclim": starViColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_vjmrc": starVrColorIndex.Add(item: csv[i]); break;
							case "st_vjmrcerr": starVrColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_vjmrclim": starVrColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_jmh2": starJhColorIndex.Add(item: csv[i]); break;
							case "st_jmh2err": starJhColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_jmh2lim": starJhColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_hmk2": starHksColorIndex.Add(item: csv[i]); break;
							case "st_hmk2err": starHksColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_hmk2lim": starHksColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_jmk2": starJksColorIndex.Add(item: csv[i]); break;
							case "st_jmk2err": starJksColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_jmk2lim": starJksColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_bmy": starByColorIndex.Add(item: csv[i]); break;
							case "st_bmyerr": starByColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_bmylim": starByColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_m1": starM1ColorIndex.Add(item: csv[i]); break;
							case "st_m1err": starM1ColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_m1lim": starM1ColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_c1": starC1ColorIndex.Add(item: csv[i]); break;
							case "st_c1err": starC1ColorIndexUncertainty.Add(item: csv[i]); break;
							case "st_c1lim": starC1ColorIndexLimitFlag.Add(item: csv[i]); break;
							case "st_colorn": starNumberOfColorMeasurements.Add(item: csv[i]); break;
						}
					}
				}
				progressBarLoadingDatabase.Hide();
				MessageBox.Show(text: "Die Datenbank wurde erfolgreich eingelesen.", caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			EnableAllControlsToLoadingDatabase();
		}

		private void KryptonButtonLoadOnlineDatabase_Click(object sender, EventArgs e)
		{
			ClearAllLists();
			DisableAllControlsToLoadingDatabase();
			EnableAllControlsToLoadingDatabase();
		}

		private void KryptonButtonLoadExternalDatabase_Click(object sender, EventArgs e)
		{
			ClearAllLists();
			DisableAllControlsToLoadingDatabase();
			EnableAllControlsToLoadingDatabase();
		}

		private void KryptonButtonSaveInternalDatabase_Click(object sender, EventArgs e)
		{
		}

		private void KryptonButtonSaveOnlineDatabase_Click(object sender, EventArgs e)
		{
		}

		#endregion

		#region Enter-Evenhandlers

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

		#endregion

		#region MouseEnter-Eventhandlers

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

		private void ToolStripButtonLoadInternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonLoadOnlineDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonLoadExternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonInformation_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemFile_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemExit_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemHelp_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemInformation_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemOpenHomepage_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemOpenGithub_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadInternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadOnlineDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripMenuItemLoadExternalDatabase_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region Leave-Eventhandlers

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

		#endregion

		#region MouseLeave-Eventhandlers

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

		private void ToolStripButtonLoadInternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonLoadOnlineDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonLoadExternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonInformation_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemFile_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemLoadDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemExit_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemHelp_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemInformation_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemOpenHomepage_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemOpenGithub_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemLoadInternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemLoadOnlineDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripMenuItemLoadExternalDatabase_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion
	}
}
