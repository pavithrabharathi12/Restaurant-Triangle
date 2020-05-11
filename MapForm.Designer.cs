namespace RestaurantTriangle
{
    partial class MapForm
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.Load_Map = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelarea = new System.Windows.Forms.Label();
            this.btnLoadCarRoute = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.txtlng = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadRestaurants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 100;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(264, 452);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 5D;
            // 
            // Load_Map
            // 
            this.Load_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Map.Location = new System.Drawing.Point(416, 237);
            this.Load_Map.Name = "Load_Map";
            this.Load_Map.Size = new System.Drawing.Size(94, 23);
            this.Load_Map.TabIndex = 1;
            this.Load_Map.Text = "Load Task1";
            this.Load_Map.UseVisualStyleBackColor = true;
            this.Load_Map.Click += new System.EventHandler(this.Load_Map_Click_1);
            // 
            // labelDistance
            // 
            this.labelDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(674, 340);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(0, 13);
            this.labelDistance.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(674, 382);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time Taken:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Area Of Triangle :";
            // 
            // labelarea
            // 
            this.labelarea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelarea.AutoSize = true;
            this.labelarea.Location = new System.Drawing.Point(674, 420);
            this.labelarea.Name = "labelarea";
            this.labelarea.Size = new System.Drawing.Size(0, 13);
            this.labelarea.TabIndex = 7;
            // 
            // btnLoadCarRoute
            // 
            this.btnLoadCarRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadCarRoute.Location = new System.Drawing.Point(416, 292);
            this.btnLoadCarRoute.Name = "btnLoadCarRoute";
            this.btnLoadCarRoute.Size = new System.Drawing.Size(94, 23);
            this.btnLoadCarRoute.TabIndex = 8;
            this.btnLoadCarRoute.Text = "Load Task 2";
            this.btnLoadCarRoute.UseVisualStyleBackColor = true;
            this.btnLoadCarRoute.Click += new System.EventHandler(this.BtnLoadCarRoute_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(285, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Home/Start location";
            // 
            // labelLatitude
            // 
            this.labelLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(303, 133);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(45, 13);
            this.labelLatitude.TabIndex = 10;
            this.labelLatitude.Text = "Latitude";
            // 
            // labelLongitude
            // 
            this.labelLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(306, 182);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(54, 13);
            this.labelLongitude.TabIndex = 11;
            this.labelLongitude.Text = "Longitude";
            // 
            // txtlat
            // 
            this.txtlat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlat.Location = new System.Drawing.Point(410, 133);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(100, 20);
            this.txtlat.TabIndex = 12;
            // 
            // txtlng
            // 
            this.txtlng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlng.Location = new System.Drawing.Point(410, 182);
            this.txtlng.Name = "txtlng";
            this.txtlng.Size = new System.Drawing.Size(100, 20);
            this.txtlng.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(285, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnLoadRestaurants
            // 
            this.btnLoadRestaurants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadRestaurants.Location = new System.Drawing.Point(288, 35);
            this.btnLoadRestaurants.Name = "btnLoadRestaurants";
            this.btnLoadRestaurants.Size = new System.Drawing.Size(118, 23);
            this.btnLoadRestaurants.TabIndex = 15;
            this.btnLoadRestaurants.Text = "Load Restaurants";
            this.btnLoadRestaurants.UseVisualStyleBackColor = true;
            this.btnLoadRestaurants.Click += new System.EventHandler(this.BtnLoadRestaurants_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadRestaurants);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtlng);
            this.Controls.Add(this.txtlat);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoadCarRoute);
            this.Controls.Add(this.labelarea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.Load_Map);
            this.Controls.Add(this.gMapControl1);
            this.Name = "MapForm";
            this.Text = "RestaurantTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button Load_Map;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelarea;
        private System.Windows.Forms.Button btnLoadCarRoute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.TextBox txtlng;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadRestaurants;
    }
}

