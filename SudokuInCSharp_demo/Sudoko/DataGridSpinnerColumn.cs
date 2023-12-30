// Author: Gokuldas Chandgadkar
// Revision: $1$
// Date: 25/12/2005


using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Sudoku
{
	/// <summary>
	/// Summary description for DataGridSpinnerColumn.
	/// This class is custom column providing spinner
	/// functionality and is derived from DataGridTextBoxColumn
	/// Since I have to make answer spots readonly this Column Style is not general purpose
	/// as to make the cell read-only the code need to be handled during Edit method.
	/// So I have exposed one property Game where we can set game instance whose servies are
	/// then used to verity whether the cell under edit is in answer position.
	/// </summary>
	public class DataGridSpinnerColumn : DataGridTextBoxColumn

	{

		private int _currentRow=-1;
		private CurrencyManager cm=null;
		private	VScrollBar vsBar;
		private Sudoku _game;
		private bool _answerPostion=false;		
		private const int COLUMN_WIDTH=30;


		
		/// <summary>
		/// Constructor
		/// </summary>
		public DataGridSpinnerColumn()
		{

			vsBar = new VScrollBar();
			// Add Scroll and Leave event handler
			vsBar.Scroll += new ScrollEventHandler(Vertical_Scroll);
			vsBar.Leave += new EventHandler(Vertical_Scroll_Leave);
			this.TextBox.Leave += new EventHandler(TextBox_Leave);

			}



		public int SpinnerWidth 
		{
			get {return vsBar.Width;}
			set { vsBar.Width=value;}


		}

		public int ScrollMaximum
		{
			set{ vsBar.Maximum = value;}
			get{ return vsBar.Maximum;}
		}

		public int ScrollMinimum 
		{
			get { return vsBar.Minimum;}
			set { vsBar.Minimum=value;}

		}

		public int ScrollSmallChange
		{
			get{return vsBar.SmallChange;}
			set{ vsBar.SmallChange =value;
				vsBar.LargeChange=value;}
		}


		public Sudoku Game
		{
			set {_game=value;}

		}
		/// <summary>
		///  Method:Scroll Handler
		///  Purpose:Set the text value to on scroll value.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Vertical_Scroll(object sender, ScrollEventArgs e)
		{
			try
			{
			int dataValue = e.NewValue;
				this.TextBox.Text =dataValue.ToString();
				
			}catch(Exception ex)
				 {
					Console.WriteLine("Error occured while scroll and is {0}",ex.Message);

				 }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void TextBox_Leave(object sender,EventArgs e)
		{

			// Set the value back
			
			
				if (this.TextBox.Text.ToString().TrimEnd()!="")
				{
					string s = this.TextBox.Text;
					base.SetColumnValueAtRow(this.cm,this._currentRow,s);
					
							
					
				}
				else
				{
					this.TextBox.ReadOnly=false;
				}
			
			if(!_answerPostion)
			{
				this.vsBar.Hide();
				this.DataGridTableStyle.DataGrid.Scroll -= 
					new EventHandler(DataGrid_Scroll);     
				Invalidate();

			}
			

			
			
		
		}
		
		/// <summary>
		/// Event Handler when scroll focus is lost.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Vertical_Scroll_Leave(object sender,EventArgs e)
		{

			// Set the value back
			
			
				if (this.TextBox.Text.ToString().TrimEnd()!="")
				{
					string s = this.TextBox.Text;
					base.SetColumnValueAtRow(this.cm,this._currentRow,s);
				}
				
			if(!_answerPostion)
			{
				this.vsBar.Hide();
				this.DataGridTableStyle.DataGrid.Scroll -= 
					new EventHandler(DataGrid_Scroll);   
				Invalidate();
			
			}
			
		  
				
			
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
//		private void Vertical_Scroll_KeyUp(object sender,KeyEventArgs e)
//		{
//			if(e.KeyCode == Keys.Up)
//			{
//				if(vsBar.Value > vsBar.Minimum)
//				{
//					vsBar.Value--;
//					this.TextBox.Text = vsBar.Value.ToString();
//				}
//			
//			}
//		
//			if(e.KeyCode == Keys.Down)
//			{
//				if(vsBar.Value < vsBar.Maximum)
//				{
//					vsBar.Value++;
//					this.TextBox.Text = vsBar.Value.ToString();
//				
//				}
//			}
//		}
//		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="rowNum"></param>
		/// <param name="bounds"></param>
		/// <param name="readOnly"></param>
		/// <param name="instantText"></param>
		/// <param name="cellIsVisible"></param>
		
		// On edit, add scroll event handler, and display combobox
		protected override void Edit(System.Windows.Forms.CurrencyManager 
			source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, 
			string instantText, bool cellIsVisible)
		{
			base.Edit(source, rowNum, bounds, readOnly, instantText, 
				cellIsVisible);

			if(this.TextBox.Text.TrimEnd()!="")
			{

				int dataValue = Int32.Parse(this.TextBox.Text);
				int pos = this.MappingName.LastIndexOf("col");
				if(pos > -1)
				{
				    string colIndex = this.MappingName.Substring(pos+3);
					int colPos = Int32.Parse(colIndex);
					_answerPostion=_game.CheckIfAnswerPosition(rowNum,colPos,dataValue);
				}
			}
			else
			{
				 _answerPostion =false;
			}
			if (!readOnly && cellIsVisible)
			{
				
				// Save current row in the DataGrid and currency manager 
				// associated with the data source for the DataGrid
				this._currentRow = rowNum;
				this.cm = source;

				if(!_answerPostion)
				{
				
					// Add event handler for DataGrid scroll notification
					this.DataGridTableStyle.DataGrid.Scroll 
						+= new EventHandler(DataGrid_Scroll);
			
					// Site the combobox control within the current cell
					this.vsBar.Parent = this.TextBox.Parent;
					Rectangle rect = 
						this.DataGridTableStyle.DataGrid.GetCurrentCellBounds();
					//Place this control to right.
					this.vsBar.Location = new Point(rect.Right-this.SpinnerWidth,rect.Top);
					this.vsBar.Size = new Size(this.SpinnerWidth,this.TextBox.Height);
				

					// Make the combobox visible and place on top textbox control
					this.vsBar.Show();
					// As textbox control also there let us bring this to front.
					this.vsBar.BringToFront();
					
					this.vsBar.Show();
					//	this.TextBox.Text= this.vsBar.Value.ToString();
					this.TextBox.ReadOnly=true;
					this.TextBox.BackColor = Color.Blue;
					this.TextBox.ForeColor=Color.White;
				
				}
				else
				{
					this.TextBox.ReadOnly=true;
					this.TextBox.BackColor=Color.White;
					this.TextBox.ForeColor =Color.Black;
				}
				
			}
		}

		public void DataGrid_Scroll(object sender,EventArgs e)
		{
		  this.vsBar.Hide();
		}

		
		// Given a row, get the value member associated with a row.  Use the
		// value member to find the associated display member by iterating 
		// over bound data source
		protected override object 
			GetColumnValueAtRow(System.Windows.Forms.CurrencyManager source, 
			int rowNum)
		{
			// Given a row number in the DataGrid, get the display member
			
			object obj =  base.GetColumnValueAtRow(source, rowNum);
			if(obj.ToString().TrimEnd() !="")
			{
				this.vsBar.Value = Int32.Parse(obj.ToString());
				//this.TextBox.Text= obj.ToString();
			}
			else
			{
				this.vsBar.Value =1;
				
		
			}

			return obj;
        
		}



		
	}
}
