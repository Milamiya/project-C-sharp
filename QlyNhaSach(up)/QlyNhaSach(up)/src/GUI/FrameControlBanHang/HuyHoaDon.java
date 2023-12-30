package GUI.FrameControlBanHang;

import java.awt.Cursor;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.table.DefaultTableModel;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;


public class HuyHoaDon extends JFrame {

	private JTable table;
	int mhd;
	
	public HuyHoaDon() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setResizable(false);
		setSize(507,254);
		setLocationRelativeTo(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/delete.png")));
		setTitle("Hủy hóa đơn");
		getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 481, 165);
		getContentPane().add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		JButton bXoa = new JButton("Xóa");
		bXoa.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bXoa.setBounds(10, 178, 481, 36);
		bXoa.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bXoa.setContentAreaFilled(false);
		getContentPane().add(bXoa);
		
		LoadTable();
		
		bXoa.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				int index = table.getSelectedRow();
				
				if(index == -1){
					JOptionPane.showMessageDialog(null, "Xin vui lòng chọn dòng cần xóa");
				}
				else{
					mhd = Integer.valueOf(table.getValueAt(index,0).toString());
					DeleteChiTietHoaDon();
					DeleteHoaDon();
					LoadTable();
				}
			}
		});
	}
	
	public void LoadTable(){
		try {

			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = "SELECT * FROM HOADON";
			ResultSet rs = statement.executeQuery(sql);
			Vector col = new Vector();
	        Vector data = new Vector();
	        col.add("Mã hóa đơn");
	        col.add("Tên khách hàng");
	        col.add("Ngày lập");
	        col.add("Tổng tiền");
	        

			while (rs.next()) {
				Vector row = new Vector();
                for (int i = 1; i <= 4; i++) {
                	
                	if(i == 3){
                		String ngay = rs.getString(i);
                		String [] date = ngay.split("-");
        				String ng = date[2] + "-" + date[1]+ "-" + date[0] ;
                		row.add(ng);
                	}
                	else{
                		 row.add(rs.getString(i));
                	}
                   
                }
                data.add(row);
			}
			table.setModel(new DefaultTableModel(data, col));
			table.getColumnModel().getColumn(1).setPreferredWidth(150);

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public void DeleteChiTietHoaDon(){
		
		try{
			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = String.format("DELETE FROM CHITIETHOADON WHERE MAHOADON = '%d'",mhd);
			int n = statement.executeUpdate(sql);
					
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public void DeleteHoaDon(){
		try{
			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = String.format("DELETE FROM HOADON WHERE MAHOADON = '%d'",mhd);
			int n = statement.executeUpdate(sql);
					
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		new HuyHoaDon().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

