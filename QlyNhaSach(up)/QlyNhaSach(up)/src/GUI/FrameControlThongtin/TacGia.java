package GUI.FrameControlThongtin;

//import .*;
import java.awt.Cursor;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.table.DefaultTableModel;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JButton;


public class TacGia extends JFrame {
	private JTextField tfMaTacGia;
	private JTextField tfTenTacGia;
	private JTextField tfNamMat;
	private JTextField tfQueQuan;
	private JTextField tfNamSinh;
	private JTable table;
	Vector col = new Vector();
    Vector data = new Vector();
    String mtg;

	public TacGia() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(547, 321);
		setLocationRelativeTo(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/author.png")));
		setTitle("Tác giả");
		setResizable(false);
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(null, "Thông tin tác giả", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 521, 82);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lbMaTacGia = new JLabel("Mã tác giả");
		lbMaTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaTacGia.setBounds(10, 26, 70, 15);
		panel.add(lbMaTacGia);
		
		JLabel lbTenTacGia = new JLabel("Tên tác giả");
		lbTenTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenTacGia.setBounds(160, 26, 70, 15);
		panel.add(lbTenTacGia);
		
		tfMaTacGia = new JTextField();
		tfMaTacGia.setBounds(77, 24, 70, 20);
		panel.add(tfMaTacGia);
		tfMaTacGia.setColumns(10);
		
		tfTenTacGia = new JTextField();
		tfTenTacGia.setBounds(228, 24, 137, 20);
		panel.add(tfTenTacGia);
		tfTenTacGia.setColumns(10);
		
		JLabel lbNamMat = new JLabel("Năm mất");
		lbNamMat.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamMat.setBounds(10, 55, 70, 15);
		panel.add(lbNamMat);
		
		tfNamMat = new JTextField();
		tfNamMat.setBounds(77, 52, 70, 20);
		panel.add(tfNamMat);
		tfNamMat.setColumns(10);
		
		JLabel lbQueQuan = new JLabel("Quê quán");
		lbQueQuan.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbQueQuan.setBounds(160, 56, 70, 15);
		panel.add(lbQueQuan);
		
		tfQueQuan = new JTextField();
		tfQueQuan.setColumns(10);
		tfQueQuan.setBounds(228, 52, 137, 20);
		panel.add(tfQueQuan);
		
		JLabel lbNamSinh = new JLabel("Năm sinh");
		lbNamSinh.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamSinh.setBounds(375, 26, 59, 15);
		panel.add(lbNamSinh);
		
		tfNamSinh = new JTextField();
		tfNamSinh.setColumns(10);
		tfNamSinh.setBounds(441, 24, 70, 20);
		panel.add(tfNamSinh);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(13, 98, 517, 138);
		getContentPane().add(scrollPane);
		
		table = new JTable(new DefaultTableModel(data, col));
		scrollPane.setViewportView(table);
		
		JButton bThem = new JButton("Thêm");
		bThem.setBounds(13, 240, 161, 42);
		bThem.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bThem.setContentAreaFilled(false);
		getContentPane().add(bThem);
		
		JButton bSua = new JButton("Sửa");
		bSua.setBounds(192, 240, 161, 42);
		bSua.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bSua.setContentAreaFilled(false);
		getContentPane().add(bSua);
		
		JButton bReset = new JButton("Reset");
		bReset.setBounds(370, 240, 161, 42);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		LoadTable();
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				tfTenTacGia.setText("");
				tfMaTacGia.setText("");
				tfNamMat.setText("");
				tfNamSinh.setText("");
				tfQueQuan.setText("");
				LoadTable();
			}
		});
		
        table.addMouseListener(new MouseAdapter() {
			
			public void mouseClicked(MouseEvent arg0) {
				// TODO Auto-generated method stub
				int index = table.getSelectedRow();
				tfMaTacGia.setText(String.valueOf(table.getValueAt(index,0)));
				tfTenTacGia.setText(String.valueOf(table.getValueAt(index,1)));
				tfNamSinh.setText(String.valueOf(table.getValueAt(index,2)));
				tfNamMat.setText(String.valueOf(table.getValueAt(index,3)));
				tfQueQuan.setText(String.valueOf(table.getValueAt(index,4)));
				mtg = String.valueOf(table.getValueAt(index,0));
			}
		});
        
        tfMaTacGia.addMouseListener(new MouseAdapter() {
			public void mouseExited(MouseEvent ev) {
				try {
					
					if(tfMaTacGia.getText().length()>4){
						JOptionPane.showMessageDialog(null,"Mã tác giả không đúng quy định");
						tfMaTacGia.requestFocus();
					}
					
					else{
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT MATACGIA FROM TACGIA WHERE MATACGIA <> '%s'",mtg);
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							if(tfMaTacGia.getText().toUpperCase().equals(rs.getString("MATACGIA"))){
								JOptionPane.showMessageDialog(null,"Mã tác giả bị trùng");
								tfMaTacGia.setText("");
							}
						}
					}
				} catch (Exception e) {
					e.printStackTrace();
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
					  if(tfMaTacGia.getText().length()!= 4){
						JOptionPane.showMessageDialog(null,"Mã tác giả không đúng quy định");
						tfMaTacGia.requestFocus();
					   }
					
				     else{
						try {
							
							Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
							String sql = String.format("UPDATE TACGIA SET MATACGIA = '%s',TENTACGIA = '%s',NAMSINH = '%s',NAMMAT = '%s',QUEQUAN = '%s' WHERE MATACGIA = '%s'",tfMaTacGia.getText().toUpperCase(),tfTenTacGia.getText().toUpperCase(),tfNamSinh.getText(),tfNamMat.getText(),tfQueQuan.getText().toUpperCase(),mtg);
							int n = statement.executeUpdate(sql);
							
							if(n==1){
								JOptionPane.showMessageDialog(null, "Chỉnh sửa thành công");
								LoadTable();
							}
							
							else{
								JOptionPane.showMessageDialog(null, "Lỗi!!");
							}

						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				}
				
				 
			}
		});
		
		bThem.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
					
					String matacgia = tfMaTacGia.getText();
					String tentacgia = tfTenTacGia.getText();
					String namsinh = tfNamSinh.getText();
					String nammat = tfNamMat.getText();
					String quequan = tfQueQuan.getText();
					
					if(tfNamSinh.getText().equals("")){
						namsinh = "NULL";
					}
					
					if(tfNamMat.getText().equals("")){
						nammat= "NULL";
					}
					
					if(tfQueQuan.getText().equals("")){
						quequan = "NULL";
					}
					
					if(matacgia.length()!=4){
						JOptionPane.showMessageDialog(null,"Mã tác giả không đúng quy định");
						tfMaTacGia.requestFocus();
					}
					
					else{
						 try{
								Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
								String sql = String.format("INSERT INTO TACGIA VALUES ('%s','%s','%s','%s','%s')",matacgia.toUpperCase(),tentacgia.toUpperCase(),namsinh,nammat,quequan.toUpperCase());
								int n = statement.executeUpdate(sql);
								

								if(n == 1){
									JOptionPane.showMessageDialog(null,"Nhập tác giả thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE);
									LoadTable();
								}
								
								else{
									JOptionPane.showMessageDialog(null,"Lỗi","Thông báo",JOptionPane.ERROR_MESSAGE);
								}

							} catch (Exception e) {
								e.printStackTrace();
							}
						}
					}
		});
		
		
		
	}
	
	public void LoadTable(){
		try {

			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = "SELECT * FROM TACGIA";
			ResultSet rs = statement.executeQuery(sql);
			Vector col = new Vector();
	        Vector data = new Vector();
	        col.add("Mã tác giả");
	        col.add("Tên tác giả");
	        col.add("Năm sinh");
	        col.add("Năm mất");
	        col.add("Quê quán");

			while (rs.next()) {
				Vector row = new Vector();
                for (int i = 1; i <= 5; i++) {
                    row.add(rs.getString(i));
                }
                data.add(row);
			}
			table.setModel(new DefaultTableModel(data, col));
			table.getColumnModel().getColumn(1).setPreferredWidth(150);

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		new TacGia().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

