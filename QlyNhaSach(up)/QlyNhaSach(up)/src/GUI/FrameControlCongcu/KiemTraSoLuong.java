package GUI.FrameControlCongcu;

import javax.swing.*;
import javax.swing.border.TitledBorder;
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

public class KiemTraSoLuong extends JFrame {
	
	private JTextField tfMaSach;
	private JTextField tfTenSach;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JButton bReset, bOK;
	private JPanel p1,p2;
	private JRadioButton rbMaSach, rbTenSach;
	JLabel txtTongSoLuong,txtSoLuongCon;
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	String inUse;
	
	public KiemTraSoLuong(){
		
		getContentPane().setFont(new Font("Tahoma", Font.PLAIN, 11));
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(458, 275);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/check.png")));
		setTitle("Kiểm tra số lượng sách");
		getContentPane().setLayout(null);
		setLocationRelativeTo(null);
		setResizable(false);
		
		p1 = new JPanel();
		p1.setBorder(new TitledBorder(null, "Nhập dữ liệu", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		p1.setBounds(10, 11, 265, 93);
		getContentPane().add(p1);
		p1.setLayout(null);
		
		rbMaSach = new JRadioButton("Mã sách");
		buttonGroup.add(rbMaSach);
		rbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbMaSach.setBounds(6, 21, 84, 23);
		p1.add(rbMaSach);
		
		rbTenSach = new JRadioButton("Tên sách");
		buttonGroup.add(rbTenSach);
		rbTenSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTenSach.setBounds(6, 55, 84, 23);
		p1.add(rbTenSach);
		
		tfMaSach = new JTextField();
		tfMaSach.setEditable(false);
		tfMaSach.setBounds(91, 23, 166, 20);
		tfMaSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		p1.add(tfMaSach);
		
		tfTenSach = new JTextField();
		tfTenSach.setEditable(false);
		tfTenSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfTenSach.setBounds(91, 57, 166, 20);
		p1.add(tfTenSach);
		
		p2 = new JPanel();
		p2.setBorder(new TitledBorder(null, "Thông tin số lượng sách", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		p2.setBounds(285, 11, 156, 93);
		getContentPane().add(p2);
		p2.setLayout(null);
		
		JLabel lbTongSoLuong = new JLabel("Tổng số lượng :");
		lbTongSoLuong.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTongSoLuong.setBounds(10, 25, 90, 22);
		p2.add(lbTongSoLuong);
		
		JLabel lbSoLuongCon = new JLabel("Số lượng còn : ");
		lbSoLuongCon.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbSoLuongCon.setBounds(10, 58, 90, 22);
		p2.add(lbSoLuongCon);
		
		txtTongSoLuong = new JLabel("");
		txtTongSoLuong.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		txtTongSoLuong.setBounds(105, 30, 36, 14);
		p2.add(txtTongSoLuong);
		
		txtSoLuongCon = new JLabel("");
		txtSoLuongCon.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		txtSoLuongCon.setBounds(105, 63, 36, 14);
		p2.add(txtSoLuongCon);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 109, 265, 130);
		getContentPane().add(scrollPane);
		scrollPane.setViewportView(list);
		
		bReset = new JButton("Reset");
		bReset.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bReset.setBounds(287, 108, 154, 57);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		bOK = new JButton("OK");
		bOK.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bOK.setBounds(287, 180, 154, 57);
		bOK.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bOK.setContentAreaFilled(false);
		getContentPane().add(bOK);
		
		rbMaSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				modelList.removeAllElements();
				txtSoLuongCon.setText("");
				txtTongSoLuong.setText("");
				tfTenSach.setText("");
				tfMaSach.setEditable(true);
				tfTenSach.setEditable(false);
				tfMaSach.requestFocus();
			}
		});
		
		rbTenSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				
				tfMaSach.setEditable(false);
				tfTenSach.setEditable(true);
				tfTenSach.requestFocus();
				modelList.removeAllElements();
				txtSoLuongCon.setText("");
				txtTongSoLuong.setText("");
				tfMaSach.setText("");
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				tfMaSach.setEditable(false);
				tfTenSach.setEditable(false);
				buttonGroup.clearSelection();
				modelList.removeAllElements();
				txtSoLuongCon.setText("");
				txtTongSoLuong.setText("");
				tfMaSach.setText("");
				tfTenSach.setText("");
			}
		});
		
		bOK.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
			  dispose();
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

								Statement statement = ketnoi.ConnectDB.getConnection()
										.createStatement();
								String sql = "SELECT TENSACH FROM SACH WHERE TENSACH LIKE '"
										+ tfTenSach.getText() + "%'";
								ResultSet rs = statement.executeQuery(sql);
								modelList.removeAllElements();
								txtSoLuongCon.setText("");
								txtTongSoLuong.setText("");

								while (rs.next()) {
									modelList.addElement(rs.getString("TENSACH"));
								}
								
								if(modelList.isEmpty()){
									JOptionPane.showMessageDialog(null,"Sách không tồn tại!!", "Thông báo", JOptionPane.ERROR_MESSAGE);
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
							txtSoLuongCon.setText("");
							txtTongSoLuong.setText("");
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
								JOptionPane.showMessageDialog(null, "Mã sách không tồn tại!!", "Thông báo", JOptionPane.ERROR_MESSAGE);
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
		
		list.addListSelectionListener(new ListSelectionListener() {
			
			@Override
			public void valueChanged(ListSelectionEvent arg0) {
				
				if(inUse.equals("Ten sach")){
					try {
						String tensach = (String) list.getSelectedValue();
	                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement(ResultSet.TYPE_SCROLL_SENSITIVE,ResultSet.CONCUR_UPDATABLE);
						String sql = String.format("SELECT TONGSOLUONG,SOLUONGCON FROM SACH,KHO WHERE SACH.MASACH = KHO.MASACH AND TENSACH = '%s'",tensach);
						ResultSet rs = statement.executeQuery(sql);

						while (rs.next()) {
							txtTongSoLuong.setText(rs.getString("TONGSOLUONG"));
							txtSoLuongCon.setText(rs.getString("SOLUONGCON"));
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				else{
					try {
						String masach = (String) list.getSelectedValue();
	                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement(ResultSet.TYPE_SCROLL_SENSITIVE,ResultSet.CONCUR_UPDATABLE);
						String sql = String.format("SELECT TONGSOLUONG,SOLUONGCON FROM KHO WHERE MASACH = '%s'",masach);
						ResultSet rs = statement.executeQuery(sql);

						while (rs.next()) {
							txtTongSoLuong.setText(rs.getString("TONGSOLUONG"));
							txtSoLuongCon.setText(rs.getString("SOLUONGCON"));
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				
			}
		});
	}
	
	public static void main(String[] args) {
		new KiemTraSoLuong().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}

