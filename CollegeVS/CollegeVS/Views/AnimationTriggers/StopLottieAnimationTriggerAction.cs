using System;
using Lottie.Forms;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public class StopLottieAnimationTriggerAction : TriggerAction<AnimationView>
    {
        protected override void Invoke(AnimationView sender)
        {
            sender.Progress = 0;
            sender.PauseAnimation();
        }
    }
}
