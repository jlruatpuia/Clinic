namespace Clinic.Controls
{
    partial class ucAppointments
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAppointments));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
            this.switchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
            this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
            this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
            this.editAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.editOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
            this.editSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
            this.deleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
            this.deleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
            this.deleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
            this.splitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
            this.changeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
            this.changeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
            this.toggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
            this.changeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.newAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
            this.newRecurringAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem();
            this.navigateViewBackwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewBackwardItem();
            this.navigateViewForwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewForwardItem();
            this.gotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
            this.viewZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewZoomInItem();
            this.viewZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewZoomOutItem();
            this.groupByNoneItem1 = new DevExpress.XtraScheduler.UI.GroupByNoneItem();
            this.groupByDateItem1 = new DevExpress.XtraScheduler.UI.GroupByDateItem();
            this.groupByResourceItem1 = new DevExpress.XtraScheduler.UI.GroupByResourceItem();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.appointmentRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup();
            this.navigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup();
            this.groupByRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup();
            this.sch = new DevExpress.XtraScheduler.SchedulerControl();
            this.schStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.bsApp = new System.Windows.Forms.BindingSource(this.components);
            this.dsClinic = new Clinic.dsClinic();
            this.bsRes = new System.Windows.Forms.BindingSource(this.components);
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController();
            this.daApp = new Clinic.dsClinicTableAdapters.AppointmentsTableAdapter();
            this.daRes = new Clinic.dsClinicTableAdapters.ResourcesTableAdapter();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchToGanttViewItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1,
            this.editAppointmentQueryItem1,
            this.editOccurrenceUICommandItem1,
            this.editSeriesUICommandItem1,
            this.deleteAppointmentsItem1,
            this.deleteOccurrenceItem1,
            this.deleteSeriesItem1,
            this.splitAppointmentItem1,
            this.changeAppointmentStatusItem1,
            this.changeAppointmentLabelItem1,
            this.toggleRecurrenceItem1,
            this.changeAppointmentReminderItem1,
            this.newAppointmentItem1,
            this.newRecurringAppointmentItem1,
            this.navigateViewBackwardItem1,
            this.navigateViewForwardItem1,
            this.gotoTodayItem1,
            this.viewZoomInItem1,
            this.viewZoomOutItem1,
            this.groupByNoneItem1,
            this.groupByDateItem1,
            this.groupByResourceItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 36;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemDuration1});
            this.ribbonControl1.Size = new System.Drawing.Size(787, 141);
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToDayViewItem1.Glyph")));
            this.switchToDayViewItem1.Id = 1;
            this.switchToDayViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToDayViewItem1.LargeGlyph")));
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToWorkWeekViewItem1.Glyph")));
            this.switchToWorkWeekViewItem1.Id = 2;
            this.switchToWorkWeekViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToWorkWeekViewItem1.LargeGlyph")));
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToWeekViewItem1.Glyph")));
            this.switchToWeekViewItem1.Id = 3;
            this.switchToWeekViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToWeekViewItem1.LargeGlyph")));
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToFullWeekViewItem1
            // 
            this.switchToFullWeekViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToFullWeekViewItem1.Glyph")));
            this.switchToFullWeekViewItem1.Id = 4;
            this.switchToFullWeekViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToFullWeekViewItem1.LargeGlyph")));
            this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToMonthViewItem1.Glyph")));
            this.switchToMonthViewItem1.Id = 5;
            this.switchToMonthViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToMonthViewItem1.LargeGlyph")));
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // switchToTimelineViewItem1
            // 
            this.switchToTimelineViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToTimelineViewItem1.Glyph")));
            this.switchToTimelineViewItem1.Id = 6;
            this.switchToTimelineViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToTimelineViewItem1.LargeGlyph")));
            this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
            // 
            // switchToGanttViewItem1
            // 
            this.switchToGanttViewItem1.Id = 7;
            this.switchToGanttViewItem1.Name = "switchToGanttViewItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchTimeScalesItem1.Glyph")));
            this.switchTimeScalesItem1.Id = 8;
            this.switchTimeScalesItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchTimeScalesItem1.LargeGlyph")));
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Id = 9;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Id = 10;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Id = 11;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // switchShowWorkTimeOnlyItem1
            // 
            this.switchShowWorkTimeOnlyItem1.Id = 12;
            this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
            // 
            // switchCellsAutoHeightItem1
            // 
            this.switchCellsAutoHeightItem1.Id = 13;
            this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
            // 
            // changeSnapToCellsUIItem1
            // 
            this.changeSnapToCellsUIItem1.Id = 14;
            this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
            // 
            // editAppointmentQueryItem1
            // 
            this.editAppointmentQueryItem1.Id = 15;
            this.editAppointmentQueryItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.editOccurrenceUICommandItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.editSeriesUICommandItem1)});
            this.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1";
            this.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editOccurrenceUICommandItem1
            // 
            this.editOccurrenceUICommandItem1.Id = 16;
            this.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1";
            // 
            // editSeriesUICommandItem1
            // 
            this.editSeriesUICommandItem1.Id = 17;
            this.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1";
            // 
            // deleteAppointmentsItem1
            // 
            this.deleteAppointmentsItem1.Id = 18;
            this.deleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOccurrenceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteSeriesItem1)});
            this.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1";
            this.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // deleteOccurrenceItem1
            // 
            this.deleteOccurrenceItem1.Id = 19;
            this.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1";
            // 
            // deleteSeriesItem1
            // 
            this.deleteSeriesItem1.Id = 20;
            this.deleteSeriesItem1.Name = "deleteSeriesItem1";
            // 
            // splitAppointmentItem1
            // 
            this.splitAppointmentItem1.Id = 21;
            this.splitAppointmentItem1.Name = "splitAppointmentItem1";
            // 
            // changeAppointmentStatusItem1
            // 
            this.changeAppointmentStatusItem1.Id = 22;
            this.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1";
            // 
            // changeAppointmentLabelItem1
            // 
            this.changeAppointmentLabelItem1.Id = 23;
            this.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1";
            // 
            // toggleRecurrenceItem1
            // 
            this.toggleRecurrenceItem1.Id = 24;
            this.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1";
            // 
            // changeAppointmentReminderItem1
            // 
            this.changeAppointmentReminderItem1.Edit = this.repositoryItemDuration1;
            this.changeAppointmentReminderItem1.Id = 25;
            this.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // newAppointmentItem1
            // 
            this.newAppointmentItem1.Id = 26;
            this.newAppointmentItem1.Name = "newAppointmentItem1";
            // 
            // newRecurringAppointmentItem1
            // 
            this.newRecurringAppointmentItem1.Id = 27;
            this.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1";
            // 
            // navigateViewBackwardItem1
            // 
            this.navigateViewBackwardItem1.Id = 28;
            this.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1";
            // 
            // navigateViewForwardItem1
            // 
            this.navigateViewForwardItem1.Id = 29;
            this.navigateViewForwardItem1.Name = "navigateViewForwardItem1";
            // 
            // gotoTodayItem1
            // 
            this.gotoTodayItem1.Id = 30;
            this.gotoTodayItem1.Name = "gotoTodayItem1";
            // 
            // viewZoomInItem1
            // 
            this.viewZoomInItem1.Id = 31;
            this.viewZoomInItem1.Name = "viewZoomInItem1";
            // 
            // viewZoomOutItem1
            // 
            this.viewZoomOutItem1.Id = 32;
            this.viewZoomOutItem1.Name = "viewZoomOutItem1";
            // 
            // groupByNoneItem1
            // 
            this.groupByNoneItem1.Id = 33;
            this.groupByNoneItem1.Name = "groupByNoneItem1";
            // 
            // groupByDateItem1
            // 
            this.groupByDateItem1.Id = 34;
            this.groupByDateItem1.Name = "groupByDateItem1";
            // 
            // groupByResourceItem1
            // 
            this.groupByResourceItem1.Id = 35;
            this.groupByResourceItem1.Name = "groupByResourceItem1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.appointmentRibbonPageGroup1,
            this.navigatorRibbonPageGroup1,
            this.arrangeRibbonPageGroup1,
            this.groupByRibbonPageGroup1});
            this.homeRibbonPage1.MergeOrder = 0;
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            this.homeRibbonPage1.Text = "Appointments";
            // 
            // appointmentRibbonPageGroup1
            // 
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newAppointmentItem1);
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newRecurringAppointmentItem1);
            this.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1";
            // 
            // navigatorRibbonPageGroup1
            // 
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewBackwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewForwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.gotoTodayItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomInItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomOutItem1);
            this.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // groupByRibbonPageGroup1
            // 
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByNoneItem1);
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByDateItem1);
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByResourceItem1);
            this.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1";
            // 
            // sch
            // 
            this.sch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sch.Location = new System.Drawing.Point(0, 141);
            this.sch.MenuManager = this.ribbonControl1;
            this.sch.Name = "sch";
            this.sch.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Sunday;
            this.sch.Size = new System.Drawing.Size(565, 317);
            this.sch.Start = new System.DateTime(2016, 10, 24, 0, 0, 0, 0);
            this.sch.Storage = this.schStorage;
            this.sch.TabIndex = 1;
            this.sch.Text = "schedulerControl1";
            this.sch.Views.DayView.TimeRulers.Add(timeRuler1);
            this.sch.Views.FullWeekView.Enabled = true;
            this.sch.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.sch.Views.GanttView.Enabled = false;
            this.sch.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.sch.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.sch_EditAppointmentFormShowing);
            // 
            // schStorage
            // 
            this.schStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PatientID", "PatientID"));
            this.schStorage.Appointments.DataSource = this.bsApp;
            this.schStorage.Appointments.Mappings.AllDay = "AllDay";
            this.schStorage.Appointments.Mappings.Description = "Description";
            this.schStorage.Appointments.Mappings.End = "EndDate";
            this.schStorage.Appointments.Mappings.Label = "Label";
            this.schStorage.Appointments.Mappings.Location = "Location";
            this.schStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schStorage.Appointments.Mappings.ResourceId = "ResourceID";
            this.schStorage.Appointments.Mappings.Start = "StartDate";
            this.schStorage.Appointments.Mappings.Status = "Status";
            this.schStorage.Appointments.Mappings.Subject = "Subject";
            this.schStorage.Appointments.Mappings.TimeZoneId = "ResourceIDs";
            this.schStorage.Appointments.Mappings.Type = "Type";
            this.schStorage.Resources.DataSource = this.bsRes;
            this.schStorage.Resources.Mappings.Caption = "ResourceName";
            this.schStorage.Resources.Mappings.Color = "Color";
            this.schStorage.Resources.Mappings.Id = "ResourceID";
            this.schStorage.Resources.Mappings.Image = "Image";
            // 
            // bsApp
            // 
            this.bsApp.DataMember = "Appointments";
            this.bsApp.DataSource = this.dsClinic;
            // 
            // dsClinic
            // 
            this.dsClinic.DataSetName = "dsClinic";
            this.dsClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsRes
            // 
            this.bsRes.DataMember = "Resources";
            this.bsRes.DataSource = this.dsClinic;
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToFullWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToTimelineViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToGanttViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController1.BarItems.Add(this.changeScaleWidthItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController1.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCellsAutoHeightItem1);
            this.schedulerBarController1.BarItems.Add(this.changeSnapToCellsUIItem1);
            this.schedulerBarController1.BarItems.Add(this.editAppointmentQueryItem1);
            this.schedulerBarController1.BarItems.Add(this.editOccurrenceUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.editSeriesUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteAppointmentsItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteOccurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteSeriesItem1);
            this.schedulerBarController1.BarItems.Add(this.splitAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentStatusItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentLabelItem1);
            this.schedulerBarController1.BarItems.Add(this.toggleRecurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentReminderItem1);
            this.schedulerBarController1.BarItems.Add(this.newAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.newRecurringAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewBackwardItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewForwardItem1);
            this.schedulerBarController1.BarItems.Add(this.gotoTodayItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomInItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomOutItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByNoneItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByDateItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByResourceItem1);
            this.schedulerBarController1.Control = this.sch;
            // 
            // daApp
            // 
            this.daApp.ClearBeforeFill = true;
            // 
            // daRes
            // 
            this.daRes.ClearBeforeFill = true;
            // 
            // dm
            // 
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("f6361576-17b9-4e95-8307-034c7a69df6a");
            this.dockPanel1.Location = new System.Drawing.Point(565, 141);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockAsTabbedDocument = false;
            this.dockPanel1.Options.AllowDockBottom = false;
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockLeft = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.FloatOnDblClick = false;
            this.dockPanel1.Options.ResizeDirection = DevExpress.XtraBars.Docking.Helpers.ResizeDirection.None;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.Options.ShowMaximizeButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(222, 200);
            this.dockPanel1.Size = new System.Drawing.Size(222, 317);
            this.dockPanel1.Text = "Navigate";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.dateNavigator1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(214, 290);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator1.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.sch;
            this.dateNavigator1.Size = new System.Drawing.Size(214, 290);
            this.dateNavigator1.TabIndex = 0;
            // 
            // ucAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sch);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucAppointments";
            this.Size = new System.Drawing.Size(787, 458);
            this.Load += new System.EventHandler(this.ucAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraScheduler.SchedulerControl sch;
        private DevExpress.XtraScheduler.SchedulerStorage schStorage;
        private DevExpress.XtraScheduler.UI.SwitchToDayViewItem switchToDayViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWeekViewItem switchToWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToMonthViewItem switchToMonthViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToGanttViewItem switchToGanttViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesItem switchTimeScalesItem1;
        private DevExpress.XtraScheduler.UI.ChangeScaleWidthItem changeScaleWidthItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
        private DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
        private DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
        private DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
        private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController1;
        private System.Windows.Forms.BindingSource bsApp;
        private dsClinic dsClinic;
        private System.Windows.Forms.BindingSource bsRes;
        private dsClinicTableAdapters.AppointmentsTableAdapter daApp;
        private dsClinicTableAdapters.ResourcesTableAdapter daRes;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraScheduler.UI.EditAppointmentQueryItem editAppointmentQueryItem1;
        private DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem editOccurrenceUICommandItem1;
        private DevExpress.XtraScheduler.UI.EditSeriesUICommandItem editSeriesUICommandItem1;
        private DevExpress.XtraScheduler.UI.DeleteAppointmentsItem deleteAppointmentsItem1;
        private DevExpress.XtraScheduler.UI.DeleteOccurrenceItem deleteOccurrenceItem1;
        private DevExpress.XtraScheduler.UI.DeleteSeriesItem deleteSeriesItem1;
        private DevExpress.XtraScheduler.UI.SplitAppointmentItem splitAppointmentItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem changeAppointmentStatusItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem changeAppointmentLabelItem1;
        private DevExpress.XtraScheduler.UI.ToggleRecurrenceItem toggleRecurrenceItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem changeAppointmentReminderItem1;
        private DevExpress.XtraScheduler.UI.RepositoryItemDuration repositoryItemDuration1;
        private DevExpress.XtraScheduler.UI.NewAppointmentItem newAppointmentItem1;
        private DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem newRecurringAppointmentItem1;
        private DevExpress.XtraScheduler.UI.NavigateViewBackwardItem navigateViewBackwardItem1;
        private DevExpress.XtraScheduler.UI.NavigateViewForwardItem navigateViewForwardItem1;
        private DevExpress.XtraScheduler.UI.GotoTodayItem gotoTodayItem1;
        private DevExpress.XtraScheduler.UI.ViewZoomInItem viewZoomInItem1;
        private DevExpress.XtraScheduler.UI.ViewZoomOutItem viewZoomOutItem1;
        private DevExpress.XtraScheduler.UI.GroupByNoneItem groupByNoneItem1;
        private DevExpress.XtraScheduler.UI.GroupByDateItem groupByDateItem1;
        private DevExpress.XtraScheduler.UI.GroupByResourceItem groupByResourceItem1;
        private DevExpress.XtraScheduler.UI.HomeRibbonPage homeRibbonPage1;
        private DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup appointmentRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup navigatorRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup groupByRibbonPageGroup1;
    }
}
