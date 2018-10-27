# realtime-audio-visualizer
Realtime Unity Audio Visualizer.   
Built and tested with Linux.

Every subfolder is a seperate Unity project.   


## Audio setup
The goal of this project is to visualize audio playing on the computer at the moment.
This is done by setting up the audio output / audio device card of the computer, as an input device (similar to a microphone).  
For details on how to set this up [see this link](https://forum.unity.com/threads/audiostream-an-audio-streaming-solution-for-all-and-everywhere.412029/page-3#post-3120495).

With this setup done, [Lasp](https://github.com/keijiro/Lasp) is used to capture the audio with very low latency (<150ms), and use the frequencies and mean amplitude etc for the visualization.


## Projects
Explanation of what each Unity project does:

#### fast_audio_loopback_v1
Using Lasp, visualize the currently playing audio on the computer, by scaling a sphere as the mean amplitude of the audio changes.

#### fast_audio_loopback_v1
