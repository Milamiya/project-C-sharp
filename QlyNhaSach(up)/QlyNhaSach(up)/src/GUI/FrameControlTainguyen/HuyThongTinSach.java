package GUI.FrameControlTainguyen;

import javax.swing.*;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import java.sql.*;
import java.awt.Cursor;
import java.awt.Font;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class HuyThongTinSach extends JFrame {
	
	private JTextField tfMaSach;
	private JTextField tfTenSach;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	String inUse;
	private JRadioButton rbMaSach, rbTenSach;
	private JButton bXoa;
	
	public HuyThongTinSach(){
		
		getContentPane().setFont(new Font("Tahoma", Font.PLAIN, 11));
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(320, 240);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/delete1.png")));
		setTitle("Hủy thông tin sách");
		getContentPane().setLayout(null);
		setLocationRelativeTo(null);
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
		tfMaSach.setColumns(10);
		
		tfTenSach = new JTextField();
		tfTenSach.setColumns(10);
		tfTenSach.setBounds(91, 45, 207, 20);
		tfTenSach.setEditable(false);
		tfTenSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		getContentPane().add(tfTenSach);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(12, 73, 209, 126);
		getContentPane().add(scrollPane);
		scrollPane.setViewportView(list);
		
		bXoa = new JButton("Xóa");
		bXoa.setBounds(227, 73, 71, 126);
		bXoa.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bXoa.setContentAreaFilled(false);
		getContentPane().add(bXoa);
		
        rbMaSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				modelList.removeAllElements();
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
				tfMaSach.setText("");
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
								String sql = "SELECT TENSACH FROM SACH WHERE TENSACH LIKE '"
										+ tfTenSach.getText() + "%'";
								ResultSet rs = statement.executeQuery(sql);
								modelList.removeAllElements();

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
         
        bXoa.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent event) {

				try {
					String tensach = String.valueOf(list.getSelectedValue());
					String masach = String.valueOf(list.getSelectedValue());
                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("DELETE FROM SACH WHERE MASACH = '%s' OR TENSACH = '%s'",masach,tensach);
					int n = statement.executeUpdate(sql);		
					if(n < 1){
						JOptionPane.showMessageDialog(null, "Lỗi", "Xóa", JOptionPane.ERROR_MESSAGE);
					}
					
					else{
						JOptionPane.showMessageDialog(null, "Xóa thành công", "Xóa", JOptionPane.INFORMATION_MESSAGE);
					}

				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
	}
	
	public static void main(String[] args) {
		new HuyThongTinSach().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}

