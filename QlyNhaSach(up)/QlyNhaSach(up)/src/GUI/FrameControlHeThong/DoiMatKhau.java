package GUI.FrameControlHeThong;

//import .*;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.LineBorder;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.Font;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.JPasswordField;
import javax.swing.JButton;

public class DoiMatKhau extends JFrame {
	private JPasswordField pfMKC;
	private JPasswordField pfMKM;
	private JPasswordField pfXNMK;

	public DoiMatKhau() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setResizable(false);
		setSize(339,247);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/password_icon.png")));
		setLocationRelativeTo(null);
		setTitle("Đổi mật khẩu");
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new LineBorder(Color.LIGHT_GRAY));
		panel.setBounds(15, 15, 302, 149);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lbMKC = new JLabel("Current password");
		lbMKC.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMKC.setBounds(19, 28, 108, 17);
		panel.add(lbMKC);
		
		JLabel lbMKM = new JLabel("New password");
		lbMKM.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMKM.setBounds(19, 70, 86, 17);
		panel.add(lbMKM);
		
		JLabel lbXNMK = new JLabel("Retype password");
		lbXNMK.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbXNMK.setBounds(19, 112, 118, 17);
		panel.add(lbXNMK);
		
		pfMKC = new JPasswordField();
		pfMKC.setBounds(136, 27, 144, 20);
		panel.add(pfMKC);
		
		pfMKM = new JPasswordField();
		pfMKM.setBounds(136, 69, 144, 20);
		panel.add(pfMKM);
		
		pfXNMK = new JPasswordField();
		pfXNMK.setBounds(136, 111, 144, 20);
		panel.add(pfXNMK);
		
		JButton bChange = new JButton("Change");
		bChange.setBounds(15, 169, 144, 35);
		bChange.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
	    bChange.setContentAreaFilled(false);
		getContentPane().add(bChange);
		
		JButton bReset = new JButton("Reset");
		bReset.setBounds(173, 169, 144, 35);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
	    bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				pfMKC.setText("");
				pfMKM.setText("");
				pfXNMK.setText("");
				pfMKC.requestFocus();
			}
		});
		
		bChange.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent ev) {
				
				String username = null;
				
				if(String.valueOf(pfMKC.getPassword()).equals("")){
					JOptionPane.showMessageDialog(null, "Chưa nhập mật khẩu cũ");
				}
				
				else if(String.valueOf(pfMKM.getPassword()).equals("")){
					JOptionPane.showMessageDialog(null, "Chưa nhập mật khẩu mới");
				}
				
				else if(String.valueOf(pfXNMK.getPassword()).equals("")){
					JOptionPane.showMessageDialog(null, "Chưa nhập mật khẩu xác nhận");
				}
				
				else if(String.valueOf(pfXNMK.getPassword()).equals(String.valueOf(pfMKM.getPassword())) == false){
					JOptionPane.showMessageDialog(null, "Mật khẩu xác nhận không trùng");
				}
				
    			else{
                   try{
                	   
                	    int j = 0;
						
       					Statement statement = ketnoi.ConnectDB.getConnection().createStatement(ResultSet.TYPE_SCROLL_SENSITIVE,ResultSet.CONCUR_UPDATABLE);
						String sql = String.format("SELECT USERNAME FROM TAIKHOAN WHERE PASSWORD = '%s'",new String(pfMKC.getPassword()));
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							username = rs.getString("USERNAME");
							j++;
						}
						
						if(j==0){
							JOptionPane.showMessageDialog(null,"Mật khẩu cũ không chính xác");
							pfMKC.setText("");
							pfMKC.requestFocus();
						}
						
						else{
							String sql1 = String.format("UPDATE TAIKHOAN SET PASSWORD = '%s' WHERE USERNAME = '%s'",new String(pfMKM.getPassword()),username);
							int n = statement.executeUpdate(sql1);
							
							if(n == 1){
								JOptionPane.showMessageDialog(null,"Đổi mật khẩu thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE);
							}
							
							else {
								JOptionPane.showMessageDialog(null,"Lỗi","Thông báo",JOptionPane.ERROR_MESSAGE);
							}
						}
					}catch(Exception e) {
						e.printStackTrace();
				}
				}
			}
		});
	}
	
	public static void main(String[] args) {
		new DoiMatKhau().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}


