﻿using System;

namespace Mesen.GUI.Config
{
   public class EmulationInfo
   {
	  public bool AllowInvalidInput = false;
	  public bool DisablePpu2004Reads = false;
	  public bool DisablePaletteRead = false;
	  public bool DisableOamAddrBug = false;
	  public bool DisablePpuReset = false;
	  public bool EnableOamDecay = false;
	  public bool UseNes101Hvc101Behavior = false;
	  public bool EnableMapperRandomPowerOnState = false;
	  public bool RandomizeCpuPpuAlignment = false;
	  public bool EnablePpu2006ScrollGlitch = false;
	  public bool EnablePpu2000ScrollGlitch = false;
	  public bool EnablePpuOamRowCorruption = false;

	  public bool UseAlternativeMmc3Irq = false;

	  [MinMax(0, 1000)] public UInt32 PpuExtraScanlinesBeforeNmi = 0;
	  [MinMax(0, 1000)] public UInt32 PpuExtraScanlinesAfterNmi = 0;

	  public RamPowerOnState RamPowerOnState;

	  public bool ShowLagCounter = false;

	  [MinMax(0, 5000)] public UInt32 EmulationSpeed = 100;
	  [MinMax(0, 5000)] public UInt32 TurboSpeed = 300;
	  [MinMax(0, 5000)] public UInt32 RewindSpeed = 100;
	  [MinMax(0, 10)] public UInt32 RunAheadFrames = 0;

	  public EmulationInfo()
	  {
	  }

	  static public void ApplyConfig()
	  {
		 EmulationInfo emulationInfo = ConfigManager.Config.EmulationInfo;

		 InteropEmu.SetEmulationSpeed(emulationInfo.EmulationSpeed);
		 InteropEmu.SetTurboRewindSpeed(emulationInfo.TurboSpeed, emulationInfo.RewindSpeed);
		 InteropEmu.SetRunAheadFrames(emulationInfo.RunAheadFrames);

		 InteropEmu.SetFlag(EmulationFlags.Mmc3IrqAltBehavior, emulationInfo.UseAlternativeMmc3Irq);
		 InteropEmu.SetFlag(EmulationFlags.AllowInvalidInput, emulationInfo.AllowInvalidInput);
		 InteropEmu.SetFlag(EmulationFlags.ShowLagCounter, emulationInfo.ShowLagCounter);
		 InteropEmu.SetFlag(EmulationFlags.DisablePpu2004Reads, emulationInfo.DisablePpu2004Reads);
		 InteropEmu.SetFlag(EmulationFlags.DisablePaletteRead, emulationInfo.DisablePaletteRead);
		 InteropEmu.SetFlag(EmulationFlags.DisableOamAddrBug, emulationInfo.DisableOamAddrBug);
		 InteropEmu.SetFlag(EmulationFlags.DisablePpuReset, emulationInfo.DisablePpuReset);
		 InteropEmu.SetFlag(EmulationFlags.EnableOamDecay, emulationInfo.EnableOamDecay);
		 InteropEmu.SetFlag(EmulationFlags.UseNes101Hvc101Behavior, emulationInfo.UseNes101Hvc101Behavior);
		 InteropEmu.SetFlag(EmulationFlags.RandomizeMapperPowerOnState, emulationInfo.EnableMapperRandomPowerOnState);
		 InteropEmu.SetFlag(EmulationFlags.RandomizeCpuPpuAlignment, emulationInfo.RandomizeCpuPpuAlignment);
		 InteropEmu.SetFlag(EmulationFlags.EnablePpu2000ScrollGlitch, emulationInfo.EnablePpu2000ScrollGlitch);
		 InteropEmu.SetFlag(EmulationFlags.EnablePpu2006ScrollGlitch, emulationInfo.EnablePpu2006ScrollGlitch);
		 InteropEmu.SetFlag(EmulationFlags.EnablePpuOamRowCorruption, emulationInfo.EnablePpuOamRowCorruption);

		 InteropEmu.SetPpuNmiConfig(emulationInfo.PpuExtraScanlinesBeforeNmi, emulationInfo.PpuExtraScanlinesAfterNmi);

		 InteropEmu.SetRamPowerOnState(emulationInfo.RamPowerOnState);
	  }
   }
}
