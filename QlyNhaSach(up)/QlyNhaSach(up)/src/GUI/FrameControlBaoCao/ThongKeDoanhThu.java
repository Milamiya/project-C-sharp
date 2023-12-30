package GUI.FrameControlBaoCao;

//import .*;
import java.awt.Cursor;
import java.awt.EventQueue;
import java.awt.Toolkit;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.LineBorder;
import java.awt.Color;
import javax.swing.JRadioButton;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.ButtonGroup;

public class ThongKeDoanhThu extends JFrame{
	private final ButtonGroup buttonGroup = new ButtonGroup();
	JRadioButton rbTKTLN,rbTKTLT,rbTKDT;
	
	public ThongKeDoanhThu() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(381,171);
		setLocationRelativeTo(null);
		setResizable(false);
		setTitle("Thống kê doanh thu");
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.Login.class.getResource("/data/img/report.png")));
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new LineBorder(Color.LIGHT_GRAY, 1, true));
		panel.setBounds(10, 11, 355, 88);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		rbTKTLT = new JRadioButton("Thống kê tiền lời của mỗi cuốn sách trong tháng");
		buttonGroup.add(rbTKTLT);
		rbTKTLT.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTKTLT.setBounds(6, 7, 316, 23);
		panel.add(rbTKTLT);
		
		rbTKTLN = new JRadioButton("Thống kê tiền lời của mỗi cuốn sách trong năm");
		buttonGroup.add(rbTKTLN);
		rbTKTLN.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTKTLN.setBounds(6, 33, 316, 23);
		panel.add(rbTKTLN);
		
	    rbTKDT = new JRadioButton("Thống kê doanh thu cả năm");
		buttonGroup.add(rbTKDT);
		rbTKDT.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTKDT.setBounds(6, 59, 316, 23);
		panel.add(rbTKDT);
		
		JButton bThongKe = new JButton("Thống kê");
		bThongKe.setBounds(10, 102, 355, 31);
		getContentPane().add(bThongKe);
		bThongKe.setContentAreaFilled(false);
		bThongKe.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		
		bThongKe.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				if(rbTKTLT.isSelected()){
					ReportTkTienLoiThang viewer = new ReportTkTienLoiThang("Report/rp_TkTienLoiThang.jasper");
					viewer.setVisible(true);
				}
				if(rbTKTLN.isSelected()){
					ReportTkTienLoiNam viewer = new ReportTkTienLoiNam("Report/rp_TkTienLoiNam.jasper");
					viewer.setVisible(true);
					
				}
				if(rbTKDT.isSelected()){
					ReportThongKeDoanhThu viewer = new ReportThongKeDoanhThu("Report/rp_TKDT.jasper");
					viewer.setVisible(true);
				}
			}
		});
	}
	
	public static void main(String[] args) {
		new ThongKeDoanhThu().setVisible(true);	
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
