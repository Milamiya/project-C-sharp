package GUI;


import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import javax.swing.JButton;

public class Login extends JFrame {
	private JTextField tfUsername;
	private JPasswordField pfPassword;
	
	public Login() {
		setIconImage(Toolkit.getDefaultToolkit().getImage(Login.class.getResource("/data/img/log_in.png")));
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(552,404);
		getContentPane().setLayout(null);
		setResizable(false);
		setLocationRelativeTo(null);
		
		JLabel lbbg = new JLabel();
		lbbg.setIcon(new ImageIcon(Login.class.getResource("/data/img/login.jpg")));
		lbbg.setBounds(-10, 0, 556, 381);
		getContentPane().add(lbbg);
		
		tfUsername = new JTextField();
		lbbg.add(tfUsername);
		tfUsername.setBounds(175, 159, 115, 20);
		tfUsername.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		pfPassword = new JPasswordField();
		pfPassword.setBounds(175, 198, 115, 20);
		lbbg.add(pfPassword);
		pfPassword.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		JButton bDangNhap = new JButton();
		bDangNhap.setBounds(163, 267, 239, 43);
		bDangNhap.setBorder(BorderFactory.createEmptyBorder());
		bDangNhap.setContentAreaFilled(false);
		bDangNhap.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		lbbg.add(bDangNhap);
		
        bDangNhap.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent arg0) {
				
				if(tfUsername.getText().equals("")){
					if(new String(pfPassword.getPassword()).equals("")){
						JOptionPane.showMessageDialog(null,"Bạn chưa nhập tên đăng nhập và mật khẩu","Invalid",JOptionPane.ERROR_MESSAGE);
						tfUsername.requestFocus();
					}
					else{
						JOptionPane.showMessageDialog(null,"Bạn chưa nhập tên đăng nhập","Invalid",JOptionPane.ERROR_MESSAGE);
						tfUsername.requestFocus();
					}		
				}
				else if(new String(pfPassword.getPassword()).equals("")){
					JOptionPane.showMessageDialog(null,"Bạn chưa nhập mật khẩu","Invalid",JOptionPane.ERROR_MESSAGE);
					pfPassword.requestFocus();
				}
				else{
					try{
						
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT USERNAME,PASSWORD FROM TAIKHOAN WHERE USERNAME = '%s' AND PASSWORD = '%s'",tfUsername.getText(),new String(pfPassword.getPassword()));
						ResultSet rs = statement.executeQuery(sql);
						
						if(rs!=null){
							if(rs.next()){
								if(tfUsername.getText().equals(rs.getString("USERNAME"))&& pfPassword.getPassword().equals(rs.getString("PASSWORD")));{
									JOptionPane.showMessageDialog(null,"Đăng nhập thành công","Login successfuly",JOptionPane.INFORMATION_MESSAGE);
									jframeMain menu = new jframeMain();
									menu.setTenUser(tfUsername.getText());
									menu.setVisible(true);
									dispose();
								}
							}
							else{
								JOptionPane.showMessageDialog(null,"Tên đăng nhập hoặc mật khẩu không đúng","Login failed",JOptionPane.ERROR_MESSAGE);
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
		new Login().setVisible(true);
	}
}
