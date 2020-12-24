using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.ComplexFilters;
using AForge.Math;
using AForge.Math.Geometry;

namespace ballotMarkingApplication
{
    public partial class frmVoting : Form
    {
        public frmVoting()
        {
            InitializeComponent();
        }
        // Declare the openfiledialog
        OpenFileDialog ofd = new OpenFileDialog();
        // Declare savefiledialog
        SaveFileDialog sfd = new SaveFileDialog();
        // Declare oledb variables
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd;
        // Declare variable
        int x = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide on startup
            hide();
            
            // Disable tools on startup
            ballotPb.Enabled = false;
            lockTextboxes();
           

            // Create connection string
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\IUCEE\\OneDrive\\Documents\\MSC PROJECT\\" +
                "Final MSC Project\\automatedMarkingApp\\finalProDB.accdb;Persist Security info=false";

            
            // Initialise labelboxes on startup
            lblXY.Text = "";
            lblARGB.Text = "";
            lblWH.Text = "";
            
            // Colour the form
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Navy;
          
        }

        private void ballotPb_MouseMove(object sender, MouseEventArgs e)
        {
            // Catch exceptions
            try
            {

                // Declare variables
                Bitmap bmp = new Bitmap(ballotPb.Image);
                Color mycolor = bmp.GetPixel(e.X, e.Y);

                // Display image properties on the labelboxes
                lblXY.Text = Convert.ToString("X=" + " " + e.X + "," + " " + "Y=" + e.Y);
                lblARGB.Text = Convert.ToString("A=" + " " + mycolor.A + "," + " " + "R=" + " " + mycolor.R + "," + " " + "G=" + " " + mycolor.G + "," + " " + "B=" + " " + mycolor.B);
                lblWH.Text = Convert.ToString("Width=" + " " + bmp.Width + "," + " " + "Height=" + " " + bmp.Height);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                // Open ballot
                openBallot();
        }

        private void invertBallot()
        {
            // Change cursor to wait cursor
            this.Cursor = Cursors.WaitCursor;
            // Declare variables
            Bitmap bmp = new Bitmap(ballotPb.Image);
            int a, r, g, b;

            // Catch exceptions
            try
            {
                // Iterate through image
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        // Get the pixels
                        a = bmp.GetPixel(x, y).A;
                        r = bmp.GetPixel(x, y).R;
                        g = bmp.GetPixel(x, y).G;
                        b = bmp.GetPixel(x, y).B;
                        // Invert the pixels
                        bmp.SetPixel(x, y, Color.FromArgb(a, 255 - r, 255 - g, 255 - b));
                    }
                }

                // Refresh and display on picturebox
                ballotPb.Refresh();
                ballotPb.Image = bmp;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            // Change cursor to default
            this.Cursor = Cursors.Default;
        }

        private void filterBlueInk()
        {
            // Declare image variable
            Bitmap bmp = new Bitmap(ballotPb.Image);
            
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 143, 63);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp);
            
            // Display result on picturebox
            ballotPb.Image = bmp;
      
        }

        private void filterGreenInk()
        {
            // Declare image variable
            Bitmap bmp = new Bitmap(ballotPb.Image);
        
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 79, 175);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp);
            
            // Display result on picturebox
            ballotPb.Image = bmp;
            
        }

        private void filterRedInk()
        {
            // Declare image variable
            Bitmap bmp = new Bitmap(ballotPb.Image);
        
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(0, 255, 255);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp);
            
            // Display result on picturebox
            ballotPb.Image = bmp;
          
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Invert ballot
            invertBallot();
        }

        private void blueInkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter if blue ink was used
                filterBlueInk();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void greenInkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter if green ink was used
                filterGreenInk();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void redInkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter if red ink was used
                filterRedInk();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void markBallot()
        {
            // Catch exceptions
            try
            {

                // Declare images
                Bitmap bmp = new Bitmap(ballotPb.Image);


                // Blob counter algorithm 
                BlobCounter blobCounter = new BlobCounter();

                // Filter blobs
                blobCounter.FilterBlobs = true;

                // Minimum width and minimum height to consider
                blobCounter.MinWidth = 30;
                blobCounter.MinHeight = 30;

                // Process image
                blobCounter.ProcessImage(bmp);

                // Array of rectangles
                Rectangle[] rects = blobCounter.GetObjectsRectangles();

                // Rectangular objects in the image
                foreach (Rectangle objectRect in rects)
                {
                    if (rects.Length > 0)
                    {


                        // Draw a rectangular border on each rectangular objects in image  
                        Graphics g = Graphics.FromImage(bmp);

                        using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                        {
                            g.DrawRectangle(pen, objectRect);
                        }
                        // Dispose Graphics1
                        g.Dispose();
                        // Display result on picturebox1
                        ballotPb.Image = bmp;
                        // Write objects on console
                        Console.WriteLine(objectRect);
                    }
                    // Identify actual votes and cancel invalid votes
                    if (blobCounter.ObjectsCount.Equals(1))
                    {

                        if (objectRect.X.Equals(484) && objectRect.Y.Equals(203) && objectRect.Width.Equals(114) && objectRect.Height.Equals(76))
                        {
                            MessageBox.Show("Voted for Conservatives");
                        }
                        else if (objectRect.X.Equals(484) && objectRect.Y.Equals(307) && objectRect.Width.Equals(114) && objectRect.Height.Equals(76))
                        {
                            MessageBox.Show("Voted for Labour");
                        }
                        else if (objectRect.X.Equals(484) && objectRect.Y.Equals(407) && objectRect.Width.Equals(114) && objectRect.Height.Equals(76))
                        {
                            MessageBox.Show("Voted for Liberal Democrats");
                        }
                        else if (objectRect.X.Equals(484) && objectRect.Y.Equals(512) && objectRect.Width.Equals(114) && objectRect.Height.Equals(75))
                        {
                            MessageBox.Show("Neutral vote");
                        }
                    }
                  
                    else if (blobCounter.ObjectsCount > 1)
                    {
                        MessageBox.Show("Multiple votes! This ballot is cancelled");
                        break;
                    }

                }

            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
     
        private void markBallotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mark the ballot paper
            markBallot();
        }

        private void openBallot()
        {
            // Enable the picturebox
            ballotPb.Enabled = true;
            // Set the filters for the image file formats
            ofd.Filter = "BMP files|*.bmp|JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|TIFF files|*.tiff";
            // Conditions to select an image
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Catch exception
                try
                {
                    ballotPb.Image = System.Drawing.Image.FromFile(ofd.FileName);

                    // Declare image variable
                    Bitmap bmp = new Bitmap(ballotPb.Image);
                    
                    // Declare new size of image
                    Size newSize = new Size(655, 644);
                    // Apply new size to the image
                    bmp = new Bitmap(ballotPb.Image, newSize);
                    
                    // Display result on picturebox
                    ballotPb.Image = bmp;
    
                    // Make image to fit picturebox
                    ballotPb.SizeMode = PictureBoxSizeMode.AutoSize;
                  
                }
                catch (Exception exc)
                { MessageBox.Show("Error:" + " " + exc.Message + "," + " " + "Please try again"); }
            }
        }

        private void saveBallot()
        {
            // Catch exception
            try
            {
                // Supported file formats for the savefile dialog
                sfd.Filter = "BMP files|*.bmp|JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|TIFF files|*.tiff";
                // Conditions to save file
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Save image
                    ballotPb.Image.Save(sfd.FileName);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save ballot
            saveBallot();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restart the application
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quit the application
            Application.Exit();
        }

        private void hide()
        {
            // Hide label boxes
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            // Hide textboxes
            txtConservatives.Visible = false;
            txtLabour.Visible = false;
            txtLiberalDemocrats.Visible = false;
            txtNeutral.Visible = false;
            txtInvalid.Visible = false;
            txtID.Visible = false;
            // Hide radiobuttons
            incrementConservatives.Visible = false;
            incrementLabour.Visible = false;
            incrementLiberalDemocrats.Visible = false;
            incrementNeutral.Visible = false;
            incrementInvalid.Visible = false;
            decrementConservatives.Visible = false;
            decrementLabour.Visible = false;
            decrementLiberalDemocrats.Visible = false;
            decrementNeutral.Visible = false;
            decrementInvalid.Visible = false;
            // Hide datagridview
            dataGridView1.Visible = false;
        }

        private void update()
        {
            
                // Open connection
                conn.Open();
                // Create an instance of oledb command
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "update votingTb set Conservatives= '" +txtConservatives .Text + "' ,Labour= '" +txtLabour .Text + "'" +
                ",[Liberal Democrats]= '" +txtLiberalDemocrats .Text + "' ,Neutral= '" +txtNeutral .Text + "' ,Invalid= '" +txtInvalid .Text + "'" +
                "where ID=" + txtID.Text + "";
                // Show query on messagebox
                MessageBox.Show(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records updated");
                //Refresh Datagridview
                dataGridView1.Refresh();
                // Close connection
                conn.Close();
                // Clear textboxes
                clear();
        }

        private void loadTable()
        {
            // sql statement
            string strSql = "Select * from votingTb";
            cmd = new OleDbCommand(strSql, conn);
            // Open database connection
            conn.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable votingTb = new DataTable();
            da.Fill(votingTb);
            dataGridView1.DataSource = votingTb;
            // Close connection
            conn.Close();
            // Clear textboxes
            clear();
        }

    
        private void clear()
        {
            // Clear textboxes
            txtConservatives.Text = "";
            txtLabour.Text = "";
            txtLiberalDemocrats.Text = "";
            txtNeutral.Text = "";
            txtInvalid.Text = "";
        }

        private void unhide()
        {
            // Unhide label boxes
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            // Unhide textboxes
            txtConservatives.Visible = true;
            txtLabour.Visible = true;
            txtLiberalDemocrats.Visible = true;
            txtNeutral.Visible = true;
            txtInvalid.Visible = true;
            txtID.Visible = true;
            // Unhide radiobuttons
            incrementConservatives.Visible = true;
            incrementLabour.Visible = true;
            incrementLiberalDemocrats.Visible = true;
            incrementNeutral.Visible = true;
            incrementInvalid.Visible = true;
            decrementConservatives.Visible = true;
            decrementLabour.Visible = true;
            decrementLiberalDemocrats.Visible = true;
            decrementNeutral.Visible = true;
            decrementInvalid.Visible = true;
            // Unhide datagridview
            dataGridView1.Visible = true;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Open database
            unhide();
        }

        private void loadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load table
            loadTable();
            
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Save vote count
            update();
            // Load table
            loadTable();
        }
          
        private void selectionChanged()
        {
            try
            {
                // Display datagridview selections on textboxes
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView1.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                   txtID.Text = row.Cells[0].Value.ToString();
                   txtConservatives.Text = row.Cells[1].Value.ToString();
                   txtLabour.Text = row.Cells[2].Value.ToString();
                   txtLiberalDemocrats.Text = row.Cells[3].Value.ToString();
                   txtNeutral . Text = row.Cells[4].Value.ToString();
                   txtInvalid . Text = row.Cells[5].Value.ToString();
                }              
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // change datagridview selection
            selectionChanged();
        }

        private void incrementConservatives_CheckedChanged(object sender, EventArgs e)
        {

            if (incrementConservatives.Checked == true)
            {               
                x = Convert.ToInt32(txtConservatives.Text) + 1;
                txtConservatives.Text = x.ToString();
            }
        }

        private void incrementLabour_CheckedChanged(object sender, EventArgs e)
        {
            if (incrementLabour.Checked == true)
            {
                x = Convert.ToInt32(txtLabour.Text) + 1;
                txtLabour.Text = x.ToString();
            }
        }

        private void incrementLiberalDemocrats_CheckedChanged(object sender, EventArgs e)
        {
            if (incrementLiberalDemocrats.Checked == true)
            {
                x = Convert.ToInt32(txtLiberalDemocrats.Text) + 1;
                txtLiberalDemocrats.Text = x.ToString();
            }
        }

        private void incrementNeutral_CheckedChanged(object sender, EventArgs e)
        {
            if (incrementNeutral.Checked == true)
            {
                x = Convert.ToInt32(txtNeutral.Text) + 1;
                txtNeutral.Text = x.ToString();
            }
        }

        private void incrementInvalid_CheckedChanged(object sender, EventArgs e)
        {
            if (incrementInvalid.Checked == true)
            {
                x = Convert.ToInt32(txtInvalid.Text) + 1;
                txtInvalid.Text = x.ToString();
            }
        }

        private void decrementConservatives_CheckedChanged(object sender, EventArgs e)
        {
            if (decrementConservatives.Checked == true)
            {
                x = Convert.ToInt32(txtConservatives.Text) - 1;
                txtConservatives.Text = x.ToString();
            }
        }

        private void decrementLabour_CheckedChanged(object sender, EventArgs e)
        {
            if (decrementLabour.Checked == true)
            {
                x = Convert.ToInt32(txtLabour.Text) - 1;
                txtLabour.Text = x.ToString();
            }
        }

        private void decrementLiberalDemocrats_CheckedChanged(object sender, EventArgs e)
        {
            if (decrementLiberalDemocrats.Checked == true)
            {
                x = Convert.ToInt32(txtLiberalDemocrats.Text) - 1;
                txtLiberalDemocrats.Text = x.ToString();
            }
        }

        private void decrementNeutral_CheckedChanged(object sender, EventArgs e)
        {
            if (decrementNeutral.Checked == true)
            {
                x = Convert.ToInt32(txtNeutral.Text) - 1;
                txtNeutral.Text = x.ToString();
            }
        }

        private void decrementInvalid_CheckedChanged(object sender, EventArgs e)
        {
            if (decrementInvalid.Checked == true)
            {
                x = Convert.ToInt32(txtInvalid.Text) - 1;
                txtInvalid.Text = x.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void lockTextboxes()
        {
            // Disable textboxes
            txtID.Enabled = false;
            txtConservatives.Enabled = false;
            txtLabour.Enabled = false;
            txtLiberalDemocrats.Enabled = false;
            txtNeutral.Enabled = false;
            txtInvalid.Enabled = false;
        }


 

    }
}
