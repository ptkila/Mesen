﻿using Mesen.GUI.Config;
using System;
using System.Windows.Forms;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmEmulationConfig : BaseConfigForm
   {
	  public frmEmulationConfig()
	  {
		 InitializeComponent();

		 tpgOverclocking.Enabled = !InteropEmu.MoviePlaying() && !InteropEmu.MovieRecording();
		 tpgAdvanced.Enabled = !InteropEmu.MoviePlaying() && !InteropEmu.MovieRecording();

		 ConfigManager.Config.EmulationInfo.EmulationSpeed = InteropEmu.GetEmulationSpeed();
		 Entity = ConfigManager.Config.EmulationInfo;

		 AddBinding("EmulationSpeed", nudEmulationSpeed);
		 AddBinding("TurboSpeed", nudTurboSpeed);
		 AddBinding("RewindSpeed", nudRewindSpeed);
		 AddBinding("RunAheadFrames", nudRunAheadFrames);

		 AddBinding("UseAlternativeMmc3Irq", chkUseAlternativeMmc3Irq);
		 AddBinding("AllowInvalidInput", chkAllowInvalidInput);
		 AddBinding("DisablePpu2004Reads", chkDisablePpu2004Reads);
		 AddBinding("DisablePaletteRead", chkDisablePaletteRead);
		 AddBinding("DisableOamAddrBug", chkDisableOamAddrBug);
		 AddBinding("DisablePpuReset", chkDisablePpuReset);
		 AddBinding("EnableOamDecay", chkEnableOamDecay);
		 AddBinding("UseNes101Hvc101Behavior", chkUseNes101Hvc101Behavior);
		 AddBinding("EnableMapperRandomPowerOnState", chkMapperRandomPowerOnState);

		 AddBinding("RandomizeCpuPpuAlignment", chkRandomizeCpuPpuAlignment);
		 AddBinding("EnablePpu2006ScrollGlitch", chkEnablePpu2006ScrollGlitch);
		 AddBinding("EnablePpu2000ScrollGlitch", chkEnablePpu2000ScrollGlitch);
		 AddBinding("EnablePpuOamRowCorruption", chkEnablePpuOamRowCorruption);

		 AddBinding("PpuExtraScanlinesBeforeNmi", nudExtraScanlinesBeforeNmi);
		 AddBinding("PpuExtraScanlinesAfterNmi", nudExtraScanlinesAfterNmi);

		 AddBinding("ShowLagCounter", chkShowLagCounter);

		 AddBinding("RamPowerOnState", cboRamPowerOnState);
	  }

	  protected override void OnFormClosed(FormClosedEventArgs e)
	  {
		 base.OnFormClosed(e);
		 EmulationInfo.ApplyConfig();
	  }

	  private void tmrUpdateClockRate_Tick(object sender, EventArgs e)
	  {
		 decimal clockRateMultiplierNtsc = (100 * (1 + (nudExtraScanlinesAfterNmi.Value + nudExtraScanlinesBeforeNmi.Value) / 262));
		 decimal clockRateMultiplierPal = (100 * (1 + (nudExtraScanlinesAfterNmi.Value + nudExtraScanlinesBeforeNmi.Value) / 312));
		 decimal clockRateMultiplierDendy = (100 * (1 + (nudExtraScanlinesAfterNmi.Value + nudExtraScanlinesBeforeNmi.Value) / 312));
		 lblEffectiveClockRateValue.Text = (1789773 * clockRateMultiplierNtsc / 100000000).ToString("#.####") + " mhz (" + ((int)clockRateMultiplierNtsc).ToString() + "%)";
		 lblEffectiveClockRateValuePal.Text = (1662607 * clockRateMultiplierPal / 100000000).ToString("#.####") + " mhz (" + ((int)clockRateMultiplierPal).ToString() + "%)";
		 lblEffectiveClockRateValueDendy.Text = (1773448 * clockRateMultiplierDendy / 100000000).ToString("#.####") + " mhz (" + ((int)clockRateMultiplierDendy).ToString() + "%)";
	  }

	  private void btnResetLagCounter_Click(object sender, EventArgs e)
	  {
		 InteropEmu.ResetLagCounter();
	  }
   }
}
