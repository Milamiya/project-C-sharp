package GUI.FrameControlTainguyen;

import java.awt.Color;
import java.awt.Cursor;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.JRadioButton;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import javax.swing.BorderFactory;
import javax.swing.ButtonGroup;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import javax.swing.SwingUtilities;
import java.util.*;
import javax.swing.border.LineBorder;

public class NhapSach extends JFrame {

	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JTextField tfMaSach;
	private JTextField tfTenSach;
	private JTextField tfSoLuong;
	private JTextField tfNgayNhap;
	JRadioButton rbMaSach, rbTenSach;
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	String inUse;
	JLabel lbTenSach,lbTenTacGia;
	
	public NhapSach() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.Login.class.getResource("/data/img/add book.png")));
		setSize(540, 320);
		getContentPane().setLayout(null);
		setResizable(false);
		setTitle("Nhập sách vào kho");
		setLocationRelativeTo(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(new LineBorder(new Color(192, 192, 192)), "Chi ti\u1EBFt nh\u1EADp s\u00E1ch", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 307, 147);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		rbMaSach = new JRadioButton("Mã sách");
		buttonGroup.add(rbMaSach);
		rbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbMaSach.setSelected(true);
		rbMaSach.setBounds(6, 53, 84, 23);
		panel.add(rbMaSach);
		
		rbTenSach = new JRadioButton("Tên sách");
		buttonGroup.add(rbTenSach);
		rbTenSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTenSach.setBounds(6, 21, 84, 23);
		panel.add(rbTenSach);
		
		tfMaSach = new JTextField();
		tfMaSach.setBounds(94, 54, 143, 20);
		panel.add(tfMaSach);
		tfMaSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		tfSoLuong = new JTextField();
		tfSoLuong.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfSoLuong.setBounds(94, 85, 109, 20);
		panel.add(tfSoLuong);
		
		JLabel lbSoLuong = new JLabel("Số lượng");
		lbSoLuong.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbSoLuong.setBounds(15, 86, 64, 17);
		panel.add(lbSoLuong);
		
		tfNgayNhap = new JTextField();
		tfNgayNhap.setBounds(94, 116, 109, 20);
		panel.add(tfNgayNhap);
		tfNgayNhap.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		JLabel lbNgayNhap = new JLabel("Ngày nhập");
		lbNgayNhap.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNgayNhap.setBounds(15, 118, 64, 15);
		panel.add(lbNgayNhap);
		
		tfTenSach = new JTextField();
		tfTenSach.setBounds(94, 23, 193, 20);
		panel.add(tfTenSach);
		tfTenSach.setEditable(false);
		tfTenSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(327, 18, 195, 210);
		getContentPane().add(scrollPane);
		scrollPane.setViewportView(list);
		
		JButton bChon = new JButton("Chọn");
		bChon.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bChon.setBounds(327, 230, 195, 48);
		bChon.setContentAreaFilled(false);
		bChon.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		getContentPane().add(bChon);
		
		JButton bNhap = new JButton("Nhập");
		bNhap.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bNhap.setBounds(12, 162, 89, 31);
		bNhap.setContentAreaFilled(false);
		bNhap.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		getContentPane().add(bNhap);
		
		JButton bThoat = new JButton("Thoát");
		bThoat.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bThoat.setBounds(227, 162, 89, 31);
		bThoat.setContentAreaFilled(false);
		bThoat.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		getContentPane().add(bThoat);
		
		JButton bReset = new JButton("Reset");
		bReset.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bReset.setBounds(119, 162, 89, 31);
		bReset.setContentAreaFilled(false);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		getContentPane().add(bReset);
		
		JPanel p1 = new JPanel();
		p1.setBorder(new TitledBorder(new LineBorder(new Color(192, 192, 192)), "Th\u00F4ng tin s\u00E1ch", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		p1.setBounds(10, 197, 307, 82);
		getContentPane().add(p1);
		p1.setLayout(null);
		
		lbTenSach = new JLabel();
		lbTenSach.setBounds(22, 25, 275, 21);
		p1.add(lbTenSach);
		
		lbTenTacGia = new JLabel();
		lbTenTacGia.setBounds(22, 50, 275, 21);
		p1.add(lbTenTacGia);
		
		this.addWindowListener(new WindowAdapter() {

			public void windowOpened(WindowEvent ev) {
				tfMaSach.requestFocus();
			}
		});
		
		rbMaSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				tfMaSach.setEditable(true);
				tfTenSach.setEditable(false);
				modelList.removeAllElements();
				tfTenSach.setText("");
				tfMaSach.setText("");
				tfSoLuong.setText("");
				tfMaSach.requestFocus();
				lbTenSach.setText("");
				lbTenTacGia.setText("");
				tfNgayNhap.setText("");
			}
		});
		
		rbTenSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				tfTenSach.setEditable(true);
				tfMaSach.setEditable(false);
				modelList.removeAllElements();
				tfTenSach.setText("");
				tfMaSach.setText("");
				tfSoLuong.setText("");
				tfTenSach.requestFocus();
				lbTenSach.setText("");
				lbTenTacGia.setText("");
				tfNgayNhap.setText("");
			}
		});
		
		bThoat.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				dispose();
				
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {				
				tfTenSach.setEditable(false);
				rbMaSach.setSelected(true);
				tfMaSach.setEditable(true);
				modelList.removeAllElements();
				tfTenSach.setText("");
				tfMaSach.setText("");
				tfSoLuong.setText("");
				tfMaSach.requestFocus();
				lbTenSach.setText("");
				lbTenTacGia.setText("");
				tfNgayNhap.setText("");
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

							while (rs.next()) {
								modelList.addElement(rs.getString("TENSACH"));
							}
							
							if(modelList.isEmpty()){
								JOptionPane.showMessageDialog(null,"Sách không tồn tại! Vui lòng khai báo thông tin sách", "Thông báo", JOptionPane.ERROR_MESSAGE);
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
							Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
							String sql = "SELECT MASACH FROM SACH";
							ResultSet rs = statement.executeQuery(sql);
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
								JOptionPane.showMessageDialog(null, "Mã sách không tồn tại! Vui lòng khai báo thông tin sách", "Thông báo", JOptionPane.ERROR_MESSAGE);
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
		
		bChon.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				if(inUse.equals("Ma sach")){
					tfMaSach.setText(String.valueOf(list.getSelectedValue()));
					modelList.clear();
					lbTenSach.setText("");
					lbTenTacGia.setText("");
					tfSoLuong.requestFocus();
				}
				
				if(inUse.equals("Ten sach")){
					tfTenSach.setText(list.getSelectedValue().toString());
					modelList.clear();
					lbTenSach.setText("");
					lbTenTacGia.setText("");
					tfSoLuong.requestFocus();
				}
				
			}
		});
		
		bNhap.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				if(inUse.equals("Ma sach")){
					String ngaynhap = null;
					if(tfNgayNhap.getText().equals("")){
						DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss"); 
						Date date = new Date();
						ngaynhap = String.valueOf(dateFormat.format(date));
					}
					
					else{
						String [] date = tfNgayNhap.getText().split("/");
						ngaynhap = date[2] + "/" + date[1]+ "/" + date[0] ;
					}
					try {		
						String ms = tfMaSach.getText();
						int sl = Integer.valueOf(tfSoLuong.getText());
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("INSERT INTO NHATKINHAPSACH(MASACH,SOLUONG,NGAYNHAP)VALUES ('%s','%d','%s')",ms,sl,ngaynhap);
						int n = statement.executeUpdate(sql);
						   if(n == 1){
								JOptionPane.showMessageDialog(null,"Nhập sách thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE);
							}
							
							else{
								JOptionPane.showMessageDialog(null,"Lỗi","Thông báo",JOptionPane.ERROR_MESSAGE);
							}
							
							
						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				
				if(inUse.equals("Ten sach")){
					String ngaynhap = null;
					if(tfNgayNhap.getText().equals("")){
						DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss"); 
						Date date = new Date();
						ngaynhap = String.valueOf(dateFormat.format(date));
					}
					
					else{
						String [] date = tfNgayNhap.getText().split("/");
						ngaynhap = date[2] + "/" + date[1]+ "/" + date[0] ;
					}
					try {
						String ts = tfTenSach.getText();
						int sl = Integer.valueOf(tfSoLuong.getText());
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String query = String.format("SELECT MASACH FROM SACH WHERE TENSACH = '%s'",ts);
						String ms = null;
						ResultSet rs = statement.executeQuery(query);
							
							while(rs.next()){
								ms = rs.getString("MASACH");
							}
							
						String sql = String.format("INSERT INTO NHATKINHAPSACH(MASACH,SOLUONG,NGAYNHAP)VALUES ('%s','%d','%s')",ms,sl,ngaynhap );
						int n = statement.executeUpdate(sql);
							
							if(n == 1){
								JOptionPane.showMessageDialog(null,"Nhập sách thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE);
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
		
       list.addListSelectionListener(new ListSelectionListener() {
			
			@Override
			public void valueChanged(ListSelectionEvent arg0) {
				
				if(inUse.equals("Ten sach")){
					try {
						String tensach = (String) list.getSelectedValue();
	                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT TENSACH,TENTACGIA FROM SACH,TACGIA WHERE SACH.MATACGIA = TACGIA.MATACGIA AND TENSACH = '%s'",tensach);
						ResultSet rs = statement.executeQuery(sql);

						while (rs.next()) {
							lbTenSach.setText(rs.getString("TENSACH"));
							lbTenTacGia.setText(rs.getString("TENTACGIA"));
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				else{
					try {
						
						String masach = (String) list.getSelectedValue();
	                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT TENSACH,TENTACGIA FROM SACH,TACGIA WHERE SACH.MATACGIA = TACGIA.MATACGIA AND MASACH = '%s'",masach);
						ResultSet rs = statement.executeQuery(sql);

						while (rs.next()) {
							lbTenSach.setText(rs.getString("TENSACH"));
							lbTenTacGia.setText(rs.getString("TENTACGIA"));
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				
			}
		});
	}
	
	public static void main(String[] args) {
		new NhapSach().setVisible(true);
	}
}

