﻿using System;
using System.Text;
using System.Threading;

namespace CppParser {

    /// <summary>
    /// An ASCII progress bar
    /// </summary>
    public class ProgressBar : IDisposable {
        private const int MaxBlockCount = 10;
        private const string Animation = @"|/-\";
        private readonly TimeSpan interval = TimeSpan.FromSeconds(1.0 / 8);

        private readonly IProgress progress;
        private readonly Timer timer;

        private string currentText = string.Empty;
        private bool disposed = false;
        private int animationIndex = 0;

        public ProgressBar(IProgress progress) {
            this.progress = progress;
            timer = new Timer(TimerHandler);

            // A progress bar is only for temporary display in a console window.
            // If the console output is redirected, draw nothing.
            if (Console.IsOutputRedirected) return;

            ResetTimer();
        }

        private void TimerHandler(object state) {
            lock (timer) {
                if (disposed) return;

                double progressValue = progress.GetProgress();
                int blockCount = (int) (progressValue * MaxBlockCount);
                int percent = (int) (progressValue * 100);
                string text = string.Format("[{0}{1}] {2,3}% {3}",
                    new string('#', blockCount), new string('-', MaxBlockCount - blockCount),
                    percent,
                    Animation[animationIndex++ % Animation.Length]);

                SetText(text);

                ResetTimer();
            }
        }

        private void SetText(string text) {
            // Get length of common portion
            int commonPrefixLength = 0;
            int commonLength = Math.Min(currentText.Length, text.Length);
            while (commonPrefixLength < commonLength && text[commonPrefixLength] == currentText[commonPrefixLength]) {
                commonPrefixLength++;
            }

            // Backtrack to the first differing character
            StringBuilder outputBuilder = new StringBuilder();
            outputBuilder.Append('\b', currentText.Length - commonPrefixLength);

            // Output new suffix
            outputBuilder.Append(text.Substring(commonPrefixLength));

            // If the new text is shorter than the old one: delete overlapping characters
            int overlapCount = currentText.Length - text.Length;
            if (overlapCount > 0) {
                outputBuilder.Append(' ', overlapCount);
                outputBuilder.Append('\b', overlapCount);
            }

            Console.Write(outputBuilder);
            currentText = text;
        }

        private void ResetTimer() {
            timer.Change(interval, TimeSpan.FromMilliseconds(-1));
        }

        public void Dispose() {
            lock (timer) {
                disposed = true;
                SetText(String.Empty);
            }
        }
    }
}