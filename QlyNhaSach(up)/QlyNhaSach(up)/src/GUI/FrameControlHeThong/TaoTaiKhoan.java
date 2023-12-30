package GUI.FrameControlHeThong;

//import .*;
import javax.swing.BorderFactory;
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
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import javax.swing.JButton;
import javax.swing.JRadioButton;
import javax.swing.ButtonGroup;

public class TaoTaiKhoan extends JFrame {
	private JTextField tfHoTen;
	private JTextField tfID;
	private JTextField tfUsername;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	String tmp;
	JRadioButton rbNVBH,rbQuanLy,rbThuKho;
	private JPasswordField pfPassword;
	private JPasswordField pfRePassword;

	public TaoTaiKhoan() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setResizable(false);
		setSize(283,425);
		setLocationRelativeTo(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/taotk.png")));
		setTitle("Tạo tài khoản");
		getContentPane().setLayout(null);
		
		JPanel p1 = new JPanel();
		p1.setBorder(new LineBorder(Color.LIGHT_GRAY, 1, true));
		p1.setBounds(10, 11, 257, 86);
		getContentPane().add(p1);
		p1.setLayout(null);
		
		JLabel lbHoTen = new JLabel("Họ tên");
		lbHoTen.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbHoTen.setBounds(10, 22, 46, 14);
		p1.add(lbHoTen);
		
		JLabel lbID = new JLabel("ID");
		lbID.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbID.setBounds(10, 53, 46, 14);
		p1.add(lbID);
		
		tfHoTen = new JTextField();
		tfHoTen.setBounds(54, 20, 193, 20);
		p1.add(tfHoTen);
		tfHoTen.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		tfID = new JTextField();
		tfID.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfID.setBounds(54, 51, 193, 20);
		p1.add(tfID);
		
		JPanel p2 = new JPanel();
		p2.setBorder(new LineBorder(new Color(192, 192, 192), 1, true));
		p2.setBounds(10, 108, 257, 115);
		getContentPane().add(p2);
		p2.setLayout(null);
		
		JLabel lbUsername = new JLabel("Username");
		lbUsername.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbUsername.setBounds(10, 22, 56, 14);
		p2.add(lbUsername);
		
		JLabel lbPassword = new JLabel("Password");
		lbPassword.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbPassword.setBounds(10, 53, 56, 14);
		p2.add(lbPassword);
		
		tfUsername = new JTextField();
		tfUsername.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfUsername.setBounds(111, 20, 136, 20);
		p2.add(tfUsername);
		
		JLabel lbRetypePassword = new JLabel("Retype password");
		lbRetypePassword.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbRetypePassword.setBounds(10, 85, 98, 15);
		p2.add(lbRetypePassword);
		
		pfPassword = new JPasswordField();
		pfPassword.setBounds(111, 51, 136, 20);
		pfPassword.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		p2.add(pfPassword);
		
		pfRePassword = new JPasswordField();
		pfRePassword.setBounds(111, 83, 136, 20);
		pfRePassword.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		p2.add(pfRePassword);
		
		JPanel p3 = new JPanel();
		p3.setBorder(new LineBorder(Color.LIGHT_GRAY, 1, true));
		p3.setBounds(10, 234, 257, 101);
		getContentPane().add(p3);
		p3.setLayout(null);
		
		rbQuanLy = new JRadioButton("Quản lý");
		buttonGroup.add(rbQuanLy);
		rbQuanLy.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbQuanLy.setBounds(6, 7, 109, 23);
		p3.add(rbQuanLy);
		
		rbThuKho = new JRadioButton("Thủ Kho");
		buttonGroup.add(rbThuKho);
		rbThuKho.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbThuKho.setBounds(6, 40, 109, 23);
		p3.add(rbThuKho);
		
		rbNVBH = new JRadioButton("Nhân viên bán hàng");
		buttonGroup.add(rbNVBH);
		rbNVBH.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbNVBH.setBounds(6, 73, 146, 23);
		p3.add(rbNVBH);
		
		JButton bOK = new JButton("OK");
		bOK.setBounds(10, 346, 257, 40);
		bOK.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bOK.setContentAreaFilled(false);
		getContentPane().add(bOK);
		
		rbNVBH.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				tmp = rbNVBH.getText();
				
			}
		});
		
		rbThuKho.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				tmp = rbThuKho.getText();
				
			}
		});
		
		rbQuanLy.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				tmp = rbQuanLy.getText();
				
			}
		});
		
		tfUsername.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseExited(MouseEvent ev) {
				try{
					String user = tfUsername.getText();
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String s = "SELECT USERNAME FROM TAIKHOAN";
					ResultSet rs = statement.executeQuery(s);
					
					while(rs.next()){
						if(user.toUpperCase().equals(rs.getString("USERNAME"))){
							JOptionPane.showMessageDialog(null,"Username đã được sử dụng","Thông báo",JOptionPane.ERROR_MESSAGE);
							tfUsername.setText("");
						}
					}
				}catch(Exception e) {
					e.printStackTrace();
			}
				
			}
			
			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
		});
		
		bOK.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent ev) {
				
				try{
					if(tfHoTen.getText().equals("")||tfID.getText().equals("")||String.valueOf(pfPassword.getPassword()).equals("")||String.valueOf(pfRePassword.getPassword()).equals("")||tfUsername.getText().equals("")){
						JOptionPane.showMessageDialog(null, "Vui lòng nhập đầy đủ thông tin");
					}
					
					else if(!String.valueOf(pfPassword.getPassword()).equals(String.valueOf(pfRePassword.getPassword()))){
						JOptionPane.showMessageDialog(null, "Mật khẩu xác nhận không đúng");
						
					}
					else{
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss"); 
						Date date = new Date();
						String ngay = String.valueOf(dateFormat.format(date));
						String sql = String.format("INSERT INTO TAIKHOAN VALUES('%s','%s','%s','%s','%s','%s')",tfUsername.getText().toUpperCase(),String.valueOf(pfPassword.getPassword()).toUpperCase(),tfHoTen.getText().toUpperCase(),tfID.getText().toUpperCase(),ngay,tmp.toUpperCase());
						int n = statement.executeUpdate(sql);
						
						if(n==1){
							JOptionPane.showMessageDialog(null, "Tạo tài khoản thành công");
							tfHoTen.setText("");
							tfUsername.setText("");
							tfID.setText("");
							pfPassword.setText("");
							pfRePassword.setText("");
							buttonGroup.clearSelection();
						}
						
						else{
							JOptionPane.showMessageDialog(null, "Lỗi");
							tfHoTen.setText("");
							tfUsername.setText("");
							tfID.setText("");
							pfPassword.setText("");
							pfRePassword.setText("");
							buttonGroup.clearSelection();
						}
					}
					
				}catch(Exception e) {
					e.printStackTrace();
			}
			}
		});
	}
	
	public static void main(String[] args) {
		new TaoTaiKhoan().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

