namespace UchebniyCenter
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSpravochniki = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUcheniki = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUchitelya = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGruppi = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrinyatUchenika = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSnyatUchenika = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmenaUchitelya = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUxodUchitelya = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperasii = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPosesheniye = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOplati = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViplatiUchetelyam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOplatiUchenikov = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOtcheti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpisokDoljnikov = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpisokKOplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpisokUchiteleyKViplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIstoriyaOplatPoUcheniku = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIstoriyaViplatPoUchitelyu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIstoriyaPosesheniya = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrafikUrokov = new System.Windows.Forms.ToolStripMenuItem();
            this.табельУчениковПоГруппамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.табельУчителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpravochniki,
            this.документыToolStripMenuItem,
            this.tsmiOperasii,
            this.tsmiOplati,
            this.tsmiOtcheti});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 28);
            this.menuStrip1.TabIndex = 1;
            // 
            // tsmiSpravochniki
            // 
            this.tsmiSpravochniki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUcheniki,
            this.tsmiUchitelya,
            this.tsmiGruppi});
            this.tsmiSpravochniki.Name = "tsmiSpravochniki";
            this.tsmiSpravochniki.Size = new System.Drawing.Size(117, 24);
            this.tsmiSpravochniki.Text = "Справочники";
            // 
            // tsmiUcheniki
            // 
            this.tsmiUcheniki.Name = "tsmiUcheniki";
            this.tsmiUcheniki.Size = new System.Drawing.Size(224, 26);
            this.tsmiUcheniki.Text = "Ученики";
            this.tsmiUcheniki.Click += new System.EventHandler(this.tsmiUcheniki_Click);
            // 
            // tsmiUchitelya
            // 
            this.tsmiUchitelya.Name = "tsmiUchitelya";
            this.tsmiUchitelya.Size = new System.Drawing.Size(224, 26);
            this.tsmiUchitelya.Text = "Учетеля";
            this.tsmiUchitelya.Click += new System.EventHandler(this.tsmiUchitelya_Click);
            // 
            // tsmiGruppi
            // 
            this.tsmiGruppi.Name = "tsmiGruppi";
            this.tsmiGruppi.Size = new System.Drawing.Size(224, 26);
            this.tsmiGruppi.Text = "Группы";
            this.tsmiGruppi.Click += new System.EventHandler(this.tsmiGruppi_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ученикиToolStripMenuItem,
            this.учителяToolStripMenuItem,
            this.группыToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // ученикиToolStripMenuItem
            // 
            this.ученикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrinyatUchenika,
            this.tsmiSnyatUchenika});
            this.ученикиToolStripMenuItem.Name = "ученикиToolStripMenuItem";
            this.ученикиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ученикиToolStripMenuItem.Text = "Ученики";
            // 
            // tsmiPrinyatUchenika
            // 
            this.tsmiPrinyatUchenika.Name = "tsmiPrinyatUchenika";
            this.tsmiPrinyatUchenika.Size = new System.Drawing.Size(276, 26);
            this.tsmiPrinyatUchenika.Text = "Принять ученика в Группу";
            this.tsmiPrinyatUchenika.Click += new System.EventHandler(this.tsmiPrinyatUchenika_Click);
            // 
            // tsmiSnyatUchenika
            // 
            this.tsmiSnyatUchenika.Name = "tsmiSnyatUchenika";
            this.tsmiSnyatUchenika.Size = new System.Drawing.Size(276, 26);
            this.tsmiSnyatUchenika.Text = "Снять Ученика с Группы";
            this.tsmiSnyatUchenika.Click += new System.EventHandler(this.tsmiSnyatUchenika_Click);
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Enabled = false;
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.учителяToolStripMenuItem.Text = "Учителя";
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSmenaUchitelya,
            this.tsmiUxodUchitelya});
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.группыToolStripMenuItem.Text = "Группы";
            // 
            // tsmiSmenaUchitelya
            // 
            this.tsmiSmenaUchitelya.Name = "tsmiSmenaUchitelya";
            this.tsmiSmenaUchitelya.Size = new System.Drawing.Size(259, 26);
            this.tsmiSmenaUchitelya.Text = "Смена Учителя Группы";
            this.tsmiSmenaUchitelya.Click += new System.EventHandler(this.tsmiSmenaUchitelya_Click);
            // 
            // tsmiUxodUchitelya
            // 
            this.tsmiUxodUchitelya.Name = "tsmiUxodUchitelya";
            this.tsmiUxodUchitelya.Size = new System.Drawing.Size(259, 26);
            this.tsmiUxodUchitelya.Text = "Уход учителя из Группы";
            this.tsmiUxodUchitelya.Click += new System.EventHandler(this.tsmiUxodUchitelya_Click);
            // 
            // tsmiOperasii
            // 
            this.tsmiOperasii.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPosesheniye});
            this.tsmiOperasii.Name = "tsmiOperasii";
            this.tsmiOperasii.Size = new System.Drawing.Size(95, 24);
            this.tsmiOperasii.Text = "Операции";
            // 
            // tsmiPosesheniye
            // 
            this.tsmiPosesheniye.Name = "tsmiPosesheniye";
            this.tsmiPosesheniye.Size = new System.Drawing.Size(224, 26);
            this.tsmiPosesheniye.Text = "Посещение";
            this.tsmiPosesheniye.Click += new System.EventHandler(this.tsmiPosesheniye_Click);
            // 
            // tsmiOplati
            // 
            this.tsmiOplati.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViplatiUchetelyam,
            this.tsmiOplatiUchenikov});
            this.tsmiOplati.Name = "tsmiOplati";
            this.tsmiOplati.Size = new System.Drawing.Size(76, 24);
            this.tsmiOplati.Text = "Оплаты";
            // 
            // tsmiViplatiUchetelyam
            // 
            this.tsmiViplatiUchetelyam.Name = "tsmiViplatiUchetelyam";
            this.tsmiViplatiUchetelyam.Size = new System.Drawing.Size(222, 26);
            this.tsmiViplatiUchetelyam.Text = "Выплаты учетелям";
            // 
            // tsmiOplatiUchenikov
            // 
            this.tsmiOplatiUchenikov.Name = "tsmiOplatiUchenikov";
            this.tsmiOplatiUchenikov.Size = new System.Drawing.Size(222, 26);
            this.tsmiOplatiUchenikov.Text = "Оплаты Учеников";
            // 
            // tsmiOtcheti
            // 
            this.tsmiOtcheti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpisokDoljnikov,
            this.tsmiSpisokKOplate,
            this.tsmiSpisokUchiteleyKViplate,
            this.tsmiIstoriyaOplatPoUcheniku,
            this.tsmiIstoriyaViplatPoUchitelyu,
            this.tsmiIstoriyaPosesheniya,
            this.tsmiGrafikUrokov,
            this.табельУчениковПоГруппамToolStripMenuItem,
            this.табельУчителейToolStripMenuItem});
            this.tsmiOtcheti.Name = "tsmiOtcheti";
            this.tsmiOtcheti.Size = new System.Drawing.Size(73, 24);
            this.tsmiOtcheti.Text = "Отчеты";
            // 
            // tsmiSpisokDoljnikov
            // 
            this.tsmiSpisokDoljnikov.Name = "tsmiSpisokDoljnikov";
            this.tsmiSpisokDoljnikov.Size = new System.Drawing.Size(298, 26);
            this.tsmiSpisokDoljnikov.Text = "Список должников";
            // 
            // tsmiSpisokKOplate
            // 
            this.tsmiSpisokKOplate.Name = "tsmiSpisokKOplate";
            this.tsmiSpisokKOplate.Size = new System.Drawing.Size(298, 26);
            this.tsmiSpisokKOplate.Text = "Список к оплате";
            // 
            // tsmiSpisokUchiteleyKViplate
            // 
            this.tsmiSpisokUchiteleyKViplate.Name = "tsmiSpisokUchiteleyKViplate";
            this.tsmiSpisokUchiteleyKViplate.Size = new System.Drawing.Size(298, 26);
            this.tsmiSpisokUchiteleyKViplate.Text = "Список учетелей к выплате";
            // 
            // tsmiIstoriyaOplatPoUcheniku
            // 
            this.tsmiIstoriyaOplatPoUcheniku.Name = "tsmiIstoriyaOplatPoUcheniku";
            this.tsmiIstoriyaOplatPoUcheniku.Size = new System.Drawing.Size(298, 26);
            this.tsmiIstoriyaOplatPoUcheniku.Text = "История оплат по ученику";
            // 
            // tsmiIstoriyaViplatPoUchitelyu
            // 
            this.tsmiIstoriyaViplatPoUchitelyu.Name = "tsmiIstoriyaViplatPoUchitelyu";
            this.tsmiIstoriyaViplatPoUchitelyu.Size = new System.Drawing.Size(298, 26);
            this.tsmiIstoriyaViplatPoUchitelyu.Text = "История выплат по учителю";
            // 
            // tsmiIstoriyaPosesheniya
            // 
            this.tsmiIstoriyaPosesheniya.Name = "tsmiIstoriyaPosesheniya";
            this.tsmiIstoriyaPosesheniya.Size = new System.Drawing.Size(298, 26);
            this.tsmiIstoriyaPosesheniya.Text = "История посещения";
            // 
            // tsmiGrafikUrokov
            // 
            this.tsmiGrafikUrokov.Name = "tsmiGrafikUrokov";
            this.tsmiGrafikUrokov.Size = new System.Drawing.Size(298, 26);
            this.tsmiGrafikUrokov.Text = "График уроков";
            this.tsmiGrafikUrokov.Click += new System.EventHandler(this.tsmiGrafikUrokov_Click);
            // 
            // табельУчениковПоГруппамToolStripMenuItem
            // 
            this.табельУчениковПоГруппамToolStripMenuItem.Name = "табельУчениковПоГруппамToolStripMenuItem";
            this.табельУчениковПоГруппамToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.табельУчениковПоГруппамToolStripMenuItem.Text = "Табель Учеников по Группам";
            // 
            // табельУчителейToolStripMenuItem
            // 
            this.табельУчителейToolStripMenuItem.Name = "табельУчителейToolStripMenuItem";
            this.табельУчителейToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.табельУчителейToolStripMenuItem.Text = "Табель Учителей";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(865, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 568);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Richmond School";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpravochniki;
        private System.Windows.Forms.ToolStripMenuItem tsmiUcheniki;
        private System.Windows.Forms.ToolStripMenuItem tsmiUchitelya;
        private System.Windows.Forms.ToolStripMenuItem tsmiGruppi;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperasii;
        private System.Windows.Forms.ToolStripMenuItem tsmiPosesheniye;
        private System.Windows.Forms.ToolStripMenuItem tsmiOplati;
        private System.Windows.Forms.ToolStripMenuItem tsmiViplatiUchetelyam;
        private System.Windows.Forms.ToolStripMenuItem tsmiOplatiUchenikov;
        private System.Windows.Forms.ToolStripMenuItem tsmiOtcheti;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpisokDoljnikov;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpisokKOplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpisokUchiteleyKViplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiIstoriyaOplatPoUcheniku;
        private System.Windows.Forms.ToolStripMenuItem tsmiIstoriyaViplatPoUchitelyu;
        private System.Windows.Forms.ToolStripMenuItem tsmiIstoriyaPosesheniya;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrafikUrokov;
        private System.Windows.Forms.ToolStripMenuItem табельУчениковПоГруппамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem табельУчителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ученикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrinyatUchenika;
        private System.Windows.Forms.ToolStripMenuItem tsmiSnyatUchenika;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmenaUchitelya;
        private System.Windows.Forms.ToolStripMenuItem tsmiUxodUchitelya;
    }
}

