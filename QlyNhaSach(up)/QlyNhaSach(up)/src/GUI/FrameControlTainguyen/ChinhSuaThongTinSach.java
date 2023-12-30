package GUI.FrameControlTainguyen;

import javax.swing.*;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import java.sql.*;
import java.awt.Cursor;
import java.awt.Font;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
public class ChinhSuaThongTinSach extends JFrame {
	
	private JTextField tfMaSach;
	private JTextField tfTenSach;
	private JTextField tftensach;
	private JTextField tfmasach;
	private JTextField tfmatacgia;
	private JTextField tflinhvuc;
	private JTextField tfloaisach;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	String inUse;
	private JRadioButton rbMaSach, rbTenSach;
	private JButton bReset, bThoat,bChinhSua,bcapnhat;
	JPanel panel;
	JLabel lbTenSach,lbMaSach,lbMaTacGia, lbMaLinhVuc, lbLoaiSach;
	String ms;
	private JTextField tfGiaNhap;
	
	public ChinhSuaThongTinSach(){
		
		getContentPane().setFont(new Font("Tahoma", Font.PLAIN, 11));
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(569, 247);
		getContentPane().setLayout(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/inforbook.png")));
		setLocationRelativeTo(null);
		setTitle("Chỉnh sửa thông tin sách");
		setResizable(false);
		
		rbMaSach = new JRadioButton("Mã sách");
		buttonGroup.add(rbMaSach);
		rbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbMaSach.setBounds(6, 7, 84, 23);
		getContentPane().add(rbMaSach);
		
		rbTenSach = new JRadioButton("Tên sách");
		buttonGroup.add(rbTenSach);
		rbTenSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTenSach.setBounds(6, 43, 84, 23);
		getContentPane().add(rbTenSach);
		
		tfMaSach = new JTextField();
		tfMaSach.setBounds(91, 9, 115, 20);
		getContentPane().add(tfMaSach);
		tfMaSach.setEditable(false);
		tfMaSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		tfTenSach = new JTextField();
		tfTenSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfTenSach.setBounds(91, 45, 180, 20);
		tfTenSach.setEditable(false);
		getContentPane().add(tfTenSach);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(12, 73, 259, 135);
		getContentPane().add(scrollPane);
		scrollPane.setViewportView(list);
		
		panel = new JPanel();
		panel.setBounds(277, 11, 275, 155);
		getContentPane().add(panel);
		panel.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		panel.setLayout(null);
		
		lbTenSach = new JLabel("Tên sách");
		lbTenSach.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		lbTenSach.setBounds(10, 11, 60, 21);
		panel.add(lbTenSach);
		
		lbMaSach = new JLabel("Mã sách");
		lbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		lbMaSach.setBounds(10, 35, 60, 21);
		panel.add(lbMaSach);
		
		lbMaTacGia = new JLabel("Mã tác giả");
		lbMaTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		lbMaTacGia.setBounds(10, 59, 60, 21);
		panel.add(lbMaTacGia);
		
		lbMaLinhVuc = new JLabel("Mã lĩnh vực");
		lbMaLinhVuc.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		lbMaLinhVuc.setBounds(10, 83, 74, 21);
		panel.add(lbMaLinhVuc);
		
		lbLoaiSach = new JLabel("Mã loại sách");
		lbLoaiSach.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		lbLoaiSach.setBounds(10, 107, 68, 21);
		panel.add(lbLoaiSach);
		
		tftensach = new JTextField();
		tftensach.setEditable(false);
		tftensach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tftensach.setBounds(84, 11, 185, 20);
		panel.add(tftensach);
		
		tfmasach = new JTextField();
		tfmasach.setEditable(false);
		tfmasach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfmasach.setBounds(84, 35, 115, 20);
		panel.add(tfmasach);
		
		tfmatacgia = new JTextField();
		tfmatacgia.setEditable(false);
		tfmatacgia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfmatacgia.setBounds(84, 59, 40, 20);
		panel.add(tfmatacgia);
		
		tflinhvuc = new JTextField();
		tflinhvuc.setEditable(false);
		tflinhvuc.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tflinhvuc.setBounds(84, 83, 40, 20);
		panel.add(tflinhvuc);
		
		tfloaisach = new JTextField();
		tfloaisach.setEditable(false);
		tfloaisach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfloaisach.setBounds(84, 107, 40, 20);
		panel.add(tfloaisach);
		
		bChinhSua = new JButton("Chỉnh sửa");
		bChinhSua.setBounds(170, 92, 95, 35);
		bChinhSua.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bChinhSua.setContentAreaFilled(false);
		panel.add(bChinhSua);
		
		JLabel lbGiaNhap = new JLabel("Giá nhập");
		lbGiaNhap.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		lbGiaNhap.setBounds(10, 131, 68, 21);
		panel.add(lbGiaNhap);
		
		tfGiaNhap = new JTextField();
		tfGiaNhap.setEditable(false);
		tfGiaNhap.setBounds(84, 131, 68, 20);
		panel.add(tfGiaNhap);
		tfGiaNhap.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		bReset = new JButton("Reset");
		bReset.setBounds(277, 170, 78, 38);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
	    bcapnhat = new JButton("Cập nhật");
		bcapnhat.setBounds(369, 170, 89, 38);
		bcapnhat.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bcapnhat.setContentAreaFilled(false);
		bcapnhat.setEnabled(false);
		getContentPane().add(bcapnhat);
		
		bThoat = new JButton("Thoát");
		bThoat.setBounds(474, 170, 78, 38);
		bThoat.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bThoat.setContentAreaFilled(false);
		getContentPane().add(bThoat);
		
        rbMaSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				modelList.removeAllElements();
				tfmasach.setText("");
				tfmatacgia.setText("");
				tftensach.setText("");
				tflinhvuc.setText("");
				tfloaisach.setText("");
				tfTenSach.setText("");
				tfMaSach.setEditable(true);
				tfTenSach.setEditable(false);
				tfMaSach.requestFocus();
				tfGiaNhap.setText("");
			}
		});
		
		rbTenSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				
				tfMaSach.setEditable(false);
				tfTenSach.setEditable(true);
				tfTenSach.requestFocus();
				modelList.removeAllElements();
				tfmasach.setText("");
				tfmatacgia.setText("");
				tftensach.setText("");
				tflinhvuc.setText("");
				tfloaisach.setText("");
				tfMaSach.setText("");
				tfGiaNhap.setText("");
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				tfMaSach.setEditable(false);
				tfTenSach.setEditable(false);
				buttonGroup.clearSelection();
				modelList.removeAllElements();
				tfmasach.setText("");
				tfmatacgia.setText("");
				tftensach.setText("");
				tflinhvuc.setText("");
				tfloaisach.setText("");
				tfMaSach.setText("");
				tfTenSach.setText("");
				tfmasach.setEditable(false);
				tfmatacgia.setEditable(false);
				tftensach.setEditable(false);
				tflinhvuc.setEditable(false);
				tfloaisach.setEditable(false);
				bcapnhat.setEnabled(false);
				tfGiaNhap.setEditable(false);
				tfGiaNhap.setText("");
			}
		});
		
		bThoat.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				dispose();
			}
		});
		
		bChinhSua.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				tfmasach.setEditable(true);
				tfmatacgia.setEditable(true);
				tftensach.setEditable(true);
				tflinhvuc.setEditable(true);
				tfloaisach.setEditable(true);
				bcapnhat.setEnabled(true);
				tfGiaNhap.setEditable(true);
			}
		});
		
        tfTenSach.getDocument().addDocumentListener(new DocumentListener() {
			
			@Override
			public void removeUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void insertUpdate(DocumentEvent arg0) {
				SwingUtilities.invokeLater(new Runnable()
				{
					public void run()
						{
						  inUse = "Ten sach";
							try {

								Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
								String sql = "SELECT TENSACH FROM SACH WHERE TENSACH LIKE '"+ tfTenSach.getText() + "%'";
								ResultSet rs = statement.executeQuery(sql);
								modelList.removeAllElements();
								tfmasach.setText("");
								tfmatacgia.setText("");
								tftensach.setText("");
								tflinhvuc.setText("");
								tfloaisach.setText("");

								while (rs.next()) {
									modelList.addElement(rs.getString("TENSACH"));
								}
								
								if(modelList.isEmpty()){
									JOptionPane.showMessageDialog(null,"Tên sách không tồn tại", "Thông báo", JOptionPane.ERROR_MESSAGE);
									tfTenSach.setText("");
								}

							} catch (Exception e) {
								e.printStackTrace();
							}
						}
				});	
				
			}
			
			@Override
			public void changedUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
		});
        
        tfMaSach.getDocument().addDocumentListener(new DocumentListener() {
			
			@Override
			public void removeUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void insertUpdate(DocumentEvent arg0) {
				
				SwingUtilities.invokeLater(new Runnable()
				{
				    public void run()
				    {
						inUse = "Ma sach";
						try {
							Statement statement = ketnoi.ConnectDB.getConnection()
									.createStatement();
							String sql = "SELECT MASACH FROM SACH";
							ResultSet rs = statement.executeQuery(sql);
							tfmasach.setText("");
							tfmatacgia.setText("");
							tftensach.setText("");
							tflinhvuc.setText("");
							tfloaisach.setText("");
							int n = tfMaSach.getText().length();
							
							if(n > 13){
								modelList.removeAllElements();
								n = 0;
								JOptionPane.showMessageDialog(null, "Mã sách dài hơn quy định!", "Không hợp lệ", JOptionPane.ERROR_MESSAGE);
								tfMaSach.setText("");
							}
							
							if(n >= 1 && n <= 13){
								modelList.removeAllElements();
								while (rs.next()) {
									String s = rs.getString("MASACH");
									if(s.substring(0,n).equals(tfMaSach.getText())){
										modelList.addElement(rs.getString("MASACH"));
									}
								}
							}
							
							if(modelList.isEmpty()){
								JOptionPane.showMessageDialog(null,"Mã sách không tồn tại", "Thông báo", JOptionPane.ERROR_MESSAGE);
								tfMaSach.setText("");
							}
						} catch (Exception e) {
							e.printStackTrace();
						}
				    }
				});				
			}
			
			@Override
			public void changedUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
		});
        
        tfmasach.addMouseListener(new MouseAdapter() {
        	
        	public void mouseExited(MouseEvent ev) {
				try {
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT MASACH FROM SACH WHERE MASACH <> '%s'",ms);
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							if(tfmasach.getText().equals(rs.getString("MASACH"))){
								JOptionPane.showMessageDialog(null,"Mã sách bị trùng");
								tfmasach.setText("");
							}
						}
					
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
        	
		});
        
        list.addListSelectionListener(new ListSelectionListener() {
			
			@Override
			public void valueChanged(ListSelectionEvent arg0) {
				
				if(inUse.equals("Ten sach")){
					try {
						String tensach = String.valueOf(list.getSelectedValue());
	                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT * FROM SACH WHERE TENSACH = '%s'",tensach);
						ResultSet rs = statement.executeQuery(sql);

						while (rs.next()) {
							tfmasach.setText(rs.getString("MASACH"));
							tfmatacgia.setText(rs.getString("MATACGIA"));
							tftensach.setText(rs.getString("TENSACH"));
							tflinhvuc.setText(rs.getString("MALINHVUC"));
							tfloaisach.setText(rs.getString("MALOAISACH"));
							tfGiaNhap.setText(rs.getString("GIAMUA"));
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				else{
					try {
						String masach = String.valueOf(list.getSelectedValue());
	                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT * FROM SACH WHERE MASACH = '%s'",masach);
						ResultSet rs = statement.executeQuery(sql);

						while (rs.next()) {
							tfmasach.setText(rs.getString("MASACH"));
							tfmatacgia.setText(rs.getString("MATACGIA"));
							tftensach.setText(rs.getString("TENSACH"));
							tflinhvuc.setText(rs.getString("MALINHVUC"));
							tfloaisach.setText(rs.getString("MALOAISACH"));
							tfGiaNhap.setText(rs.getString("GIAMUA"));
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				
				ms = tfmasach.getText();
				
			}
		});
        
        bcapnhat.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				try {
					String mas = tfmasach.getText();
					String ts = tftensach.getText();
					String ls = tfloaisach.getText();
					String lv = tflinhvuc.getText();
					String tg = tfmatacgia.getText();
					int gia = Integer.valueOf(tfGiaNhap.getText());
					
                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("UPDATE SACH SET MASACH = '%s',TENSACH = N'%s', MATACGIA = '%s', MALOAISACH = '%s', MALINHVUC = '%s',GIAMUA = '%d' WHERE MASACH = '%s'",mas,ts,tg,ls,lv,gia,ms);
                    int n = statement.executeUpdate(sql);
					
					if(n == 1){
						JOptionPane.showMessageDialog(null,"Cập nhật thành công","Cập nhật",JOptionPane.INFORMATION_MESSAGE);
					}
					
					else {
						
						JOptionPane.showMessageDialog(null,"Lỗi cập nhật","Cập nhật",JOptionPane.ERROR_MESSAGE);
						if(ms.length()!= 13){
							JOptionPane.showMessageDialog(null,"Mã sách không đúng quy định","Cập nhật",JOptionPane.ERROR_MESSAGE);
						}
						if(tg.length()!= 4){
							JOptionPane.showMessageDialog(null,"Mã tác giả không đúng quy định","Cập nhật",JOptionPane.ERROR_MESSAGE);
						}
						if(ls.length()!= 2){
							JOptionPane.showMessageDialog(null,"Mã loại sách không đúng quy định","Cập nhật",JOptionPane.ERROR_MESSAGE);
						}
						if(lv.length()!= 2){
							JOptionPane.showMessageDialog(null,"Mã lĩnh vực không đúng quy định","Cập nhật",JOptionPane.ERROR_MESSAGE);
						}
					}

				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
	}
	
	public static void main(String[] args) {
		new ChinhSuaThongTinSach().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

