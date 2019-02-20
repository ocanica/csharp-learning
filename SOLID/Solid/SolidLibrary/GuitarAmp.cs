using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLibrary
{
    public class GuitarAmp : IGuitarAmp
    {
        private readonly IVolumeComponent _volumeComponent;
        private readonly ISpecialEffectsComponent _specialEffectsComponent;
        private readonly IHeadphoneComponent _headphoneComponent;
        private readonly IFootSwitchComponent _footSwitchComponent;

        public GuitarAmp(IVolumeComponent volumeComponent,
            ISpecialEffectsComponent specialEffectsComponent,
            IHeadphoneComponent headphoneComponent,
            IFootSwitchComponent footSwitchComponent)
        {
            _volumeComponent = volumeComponent;
            _specialEffectsComponent = specialEffectsComponent;
            _headphoneComponent = headphoneComponent;
            _footSwitchComponent = footSwitchComponent;
        }

        public void PlayAwesome()
        {
            _volumeComponent.VolumeUp();
            _volumeComponent.VolumeUp();

            _headphoneComponent.OutputToHeadphones();
            _specialEffectsComponent.AddSpecialEffects();
        }
    }
}
