package GUI.FrameControlTainguyen;

import java.awt.Color;
import java.awt.Toolkit;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.Font;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;
import javax.swing.JTextField;

public class XemTTTG extends JFrame {
	private JTextField tfMaTacGia;
	Vector col = new Vector();
    Vector data = new Vector();
    private JLabel lbTenTacGia;
    private JTextField tfTenTacGia;
    private JTextField tfNamSinh;
    private JTextField tfNamMat;
    private JTextField tfQueQuan;
    private JLabel lbNamSinh;
    private JLabel lbNamMat;
    private JLabel lbQueQuan;
	
	public XemTTTG() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 291, 206);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/info.png")));
		setTitle("Thông tin");
		setLocationRelativeTo(null);
		setResizable(false);
		getContentPane().setLayout(null);
		
		JLabel lbMaTacGia = new JLabel("Mã tác giả");
		lbMaTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaTacGia.setBounds(10, 22, 68, 15);
		getContentPane().add(lbMaTacGia);
		
		tfMaTacGia = new JTextField();
		tfMaTacGia.setEditable(false);
		tfMaTacGia.setBounds(78, 20, 86, 20);
		getContentPane().add(tfMaTacGia);
		tfMaTacGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		lbTenTacGia = new JLabel("Tên tác giả");
		lbTenTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenTacGia.setBounds(10, 53, 68, 15);
		getContentPane().add(lbTenTacGia);
		
		tfTenTacGia = new JTextField();
		tfTenTacGia.setEditable(false);
		tfTenTacGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfTenTacGia.setBounds(78, 51, 197, 20);
		getContentPane().add(tfTenTacGia);
		
		tfNamSinh = new JTextField();
		tfNamSinh.setEditable(false);
		tfNamSinh.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNamSinh.setBounds(78, 82, 86, 20);
		getContentPane().add(tfNamSinh);
		
		tfNamMat = new JTextField();
		tfNamMat.setEditable(false);
		tfNamMat.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNamMat.setBounds(78, 113, 86, 20);
		getContentPane().add(tfNamMat);
		
		tfQueQuan = new JTextField();
		tfQueQuan.setEditable(false);
		tfQueQuan.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfQueQuan.setBounds(78, 144, 145, 20);
		getContentPane().add(tfQueQuan);
		
		lbNamSinh = new JLabel("Năm sinh");
		lbNamSinh.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamSinh.setBounds(10, 85, 68, 15);
		getContentPane().add(lbNamSinh);
		
		lbNamMat = new JLabel("Năm mất");
		lbNamMat.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamMat.setBounds(10, 116, 68, 15);
		getContentPane().add(lbNamMat);
		
		lbQueQuan = new JLabel("Quê quán");
		lbQueQuan.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbQueQuan.setBounds(10, 147, 68, 15);
		getContentPane().add(lbQueQuan);
		
		this.addWindowListener(new WindowAdapter() {

			public void windowOpened(WindowEvent ev) {
				try {
					
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("SELECT TENTACGIA,NAMSINH,NAMMAT,QUEQUAN FROM TACGIA WHERE MATACGIA = '%s'",tfMaTacGia.getText().toUpperCase());
					ResultSet rs = statement.executeQuery(sql);
					
					while(rs.next()){
						tfTenTacGia.setText(rs.getString("TENTACGIA"));
						tfNamSinh.setText(rs.getString("NAMSINH"));
						tfNamMat.setText(rs.getString("NAMMAT"));
						tfQueQuan.setText(rs.getString("QUEQUAN"));
					}

				} catch (Exception e) {
					e.printStackTrace();
			    }

			}
		});
	}
	
	public void setMaTacGia(String matg){
		this.tfMaTacGia.setText(matg);
	}
	
	public static void main(String[] args) {
		new XemTTTG().setVisible(true);
	}
}


