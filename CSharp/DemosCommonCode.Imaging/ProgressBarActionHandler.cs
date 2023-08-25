using System;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Imaging.Utils;

namespace DemosCommonCode.Imaging
{
    /// <summary>
    /// Provides an action handler that displays progress in <see cref="ProgressBar"/>.
    /// </summary>
    public class ProgressBarActionHandler : IActionProgressHandler
    {

        #region Fields

        /// <summary>
        /// The progress bar.
        /// </summary>
        ProgressBar _progressBar;

        /// <summary>
        /// The progress label.
        /// </summary>
        Label _progressLabel;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarActionHandler"/> class.
        /// </summary>
        /// <param name="progressBar">The progress bar.</param>
        /// <param name="progressLabel">The progress label.</param>
        public ProgressBarActionHandler(ProgressBar progressBar, Label progressLabel)
        {
            _progressBar = progressBar;
            _progressLabel = progressLabel;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Called when action step is changed.
        /// </summary>
        /// <param name="actionProgressController">The action progress controller.</param>
        /// <param name="actionStep">The action step.</param>
        /// <param name="canCancel">Indicates that action can be canceled.</param>
        /// <returns>
        /// <b>False</b> action is canceled; otherwise, <b>true</b>.
        /// </returns>
        public bool OnActionStep(ActionProgressController actionProgressController, double actionStep, bool canCancel)
        {
            if (actionProgressController.ActionLevel == 0)
                SetProgressValue(actionStep, actionProgressController.StepCount);
            return true;
        }

        /// <summary>
        /// Resets this action progress controller.
        /// </summary>
        public void Reset()
        {
            SetProgressValue(0, 100);
        }


        /// <summary>
        /// Call <see cref="ProgressUpdated"/> event.
        /// </summary>
        protected virtual void OnProgressUpdated(EventArgs e)
        {
            if (ProgressUpdated != null)
                ProgressUpdated(this, e);
        }


        /// <summary>
        /// Sets the progress value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="maxValue">The maximum value.</param>
        private void SetProgressValue(double value, double maxValue)
        {
            Control control;
            if (_progressBar != null)
                control = _progressBar;
            else
                control = _progressLabel;
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new SetProgressValueDelegate(SetProgressValue), value, maxValue);
            }
            else
            {
                if (_progressBar != null)
                    _progressBar.Value = _progressBar.Minimum + (int)Math.Round(value / maxValue * (_progressBar.Maximum - _progressBar.Minimum));
                if (_progressLabel != null)
                    _progressLabel.Text = string.Format(CultureInfo.InvariantCulture, "{0:f2}%", value / maxValue * 100);
                OnProgressUpdated(EventArgs.Empty);
            }
        }

        #endregion



        #region Events

        /// <summary>
        /// Occurs when progress is updated.
        /// </summary>
        public event EventHandler ProgressUpdated;

        #endregion



        #region Delegates

        delegate void SetProgressValueDelegate(double value, double maxValue);

        #endregion

    }
}