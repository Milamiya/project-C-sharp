package GUI.FrameControlThongtin;

//import .*;
import java.awt.Cursor;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.table.DefaultTableModel;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;
import javax.swing.JTextField;


public class LinhVuc extends JFrame {
	private JTable table;
	private JTextField tfMaLinhVuc;
	private JTextField tfTenLinhVuc;

	public LinhVuc() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(475, 236);
		getContentPane().setLayout(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/kb.png")));
		setTitle("Lĩnh vực");
		setResizable(false);
		setLocationRelativeTo(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(null, "Th\u00F4ng tin l\u0129nh v\u1EF1c", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 447, 60);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lbMaLinhVuc = new JLabel("Mã lĩnh vực");
		lbMaLinhVuc.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaLinhVuc.setBounds(10, 24, 73, 14);
		panel.add(lbMaLinhVuc);
		
		tfMaLinhVuc = new JTextField();
		tfMaLinhVuc.setBounds(84, 22, 80, 20);
		panel.add(tfMaLinhVuc);
		tfMaLinhVuc.setColumns(10);
		
		JLabel lbTenLinhVuc = new JLabel("Tên lĩnh vực");
		lbTenLinhVuc.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenLinhVuc.setBounds(189, 25, 73, 14);
		panel.add(lbTenLinhVuc);
		
		tfTenLinhVuc = new JTextField();
		tfTenLinhVuc.setColumns(10);
		tfTenLinhVuc.setBounds(269, 22, 168, 20);
		panel.add(tfTenLinhVuc);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 75, 308, 121);
		getContentPane().add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		JButton bThem = new JButton("Thêm");
		bThem.setBounds(325, 75, 130, 35);
		bThem.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bThem.setContentAreaFilled(false);
		getContentPane().add(bThem);
		
		JButton bReset = new JButton("Reset");
		bReset.setBounds(325, 161, 130, 35);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
	    bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		JButton bSua = new JButton("Sửa");
		bSua.setBounds(325, 118, 130, 35);
		bSua.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bSua.setContentAreaFilled(false);
		getContentPane().add(bSua);
		
		LoadTable();
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
			   tfMaLinhVuc.setText("");
			   tfTenLinhVuc.setText("");
			   LoadTable();
			}
		});
		
		tfMaLinhVuc.addMouseListener(new MouseAdapter() {
			public void mouseExited(MouseEvent ev) {
				try {
					
					if(tfMaLinhVuc.getText().length()>2){
						JOptionPane.showMessageDialog(null,"Mã lĩnh vực không đúng quy định");
						tfMaLinhVuc.requestFocus();
					}
					
					else{
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = "SELECT MALINHVUC FROM LINHVUC";
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							if(tfMaLinhVuc.getText().toUpperCase().equals(rs.getString("MALINHVUC"))){
								JOptionPane.showMessageDialog(null,"Mã lĩnh vực bị trùng");
								tfMaLinhVuc.setText("");
							}
						}
					}
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
		
		bThem.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent ev) {
				String malv = tfMaLinhVuc.getText();
				String tenlv = tfTenLinhVuc.getText();
				
				if(malv.equals("") || tenlv.equals("")){
					JOptionPane.showMessageDialog(null, "Vui lòng điền thông tin đầy đủ","Thông báo",JOptionPane.INFORMATION_MESSAGE);
				}
				
				else if(malv.length()<2){
					JOptionPane.showMessageDialog(null,"Mã loại sách không đúng quy định");
					tfMaLinhVuc.requestFocus();
				}
				
				else {
					try {

						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("INSERT INTO LINHVUC VALUES ('%s','%s')", malv.toUpperCase(),tenlv.toUpperCase());
						int n = statement.executeUpdate(sql);
						
						if(n == 1){ 
					    	JOptionPane.showMessageDialog(null,"Thêm lĩnh vực mới thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE); 
					     }
						else{ 
							JOptionPane.showMessageDialog(null,"Lỗi!! Vui lòng kiểm tra lại","Thông báo",JOptionPane.ERROR_MESSAGE); 
						 }
						LoadTable();

					} catch (Exception e) {
						e.printStackTrace();
					}
					
				}
				
			}
		});
		
		bSua.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent ev) {
				int index = table.getSelectedRow();
				if(index == -1){
					JOptionPane.showMessageDialog(null, "Xin vui lòng chọn dòng cần sửa");
				}
				
				else{
					if(tfMaLinhVuc.getText().equals("")||tfTenLinhVuc.getText().equals("")){
						JOptionPane.showMessageDialog(null,"Vui lòng điền đầy đủ thoongg tin");
					}
					
					else if(tfMaLinhVuc.getText().length()<2){
						JOptionPane.showMessageDialog(null,"Mã loại sách không đúng quy định");
						tfMaLinhVuc.requestFocus();
					}
					else{
						try {
							String mlv = String.valueOf(table.getValueAt(index,0));
							Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
							String sql = String.format("UPDATE LINHVUC SET MALINHVUC = '%s',TENLINHVUC = '%s' WHERE MALINHVUC = '%s'",tfMaLinhVuc.getText().toUpperCase(),tfTenLinhVuc.getText().toUpperCase(),mlv);
							int n = statement.executeUpdate(sql);
							
							if(n==1){
								JOptionPane.showMessageDialog(null, "Chỉnh sửa thành công");
								LoadTable();
							}
							
							else{
								JOptionPane.showMessageDialog(null, "Lỗi!!Vui lòng kiểm tra lại");
							}

						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				}
			}
		});
		
		table.addMouseListener(new MouseAdapter() {
			
			public void mouseClicked(MouseEvent arg0) {
				// TODO Auto-generated method stub
				int index = table.getSelectedRow();
				tfMaLinhVuc.setText(String.valueOf(table.getValueAt(index,0)));
				tfTenLinhVuc.setText(String.valueOf(table.getValueAt(index,1)));
			}
		 
		});
	}
	
	public void LoadTable(){
		try {

			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = "SELECT * FROM LINHVUC";
			ResultSet rs = statement.executeQuery(sql);
			Vector col = new Vector();
	        Vector data = new Vector();
	        col.add("Mã lĩnh vực");
	        col.add("Tên lĩnh vục");
	        

			while (rs.next()) {
				Vector row = new Vector();
                for (int i = 1; i <= 2; i++) {
                    row.add(rs.getString(i));
                }
                data.add(row);
			}
			table.setModel(new DefaultTableModel(data, col));
			table.getColumnModel().getColumn(1).setPreferredWidth(200);

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {
		new LinhVuc().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

