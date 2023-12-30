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


public class ThongKeSach extends JFrame {
	private final ButtonGroup buttonGroup = new ButtonGroup();
	JRadioButton rbTKS,rbTKT,rbTKN;


	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ThongKeSach frame = new ThongKeSach();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public ThongKeSach() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(381,171);
		setLocationRelativeTo(null);
		setResizable(false);
		setTitle("Thống kê sách");
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.Login.class.getResource("/data/img/report.png")));
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new LineBorder(Color.LIGHT_GRAY, 1, true));
		panel.setBounds(10, 11, 355, 88);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		rbTKS = new JRadioButton("Thống kê số lượng sách hiện có trong kho");
		buttonGroup.add(rbTKS);
		rbTKS.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTKS.setBounds(6, 7, 316, 23);
		panel.add(rbTKS);
		
		rbTKT = new JRadioButton("Thống kê số sách nhập và bán ra trong tháng");
		buttonGroup.add(rbTKT);
		rbTKT.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTKT.setBounds(6, 33, 316, 23);
		panel.add(rbTKT);
		
	    rbTKN = new JRadioButton("Thống kê số sách nhập và bán ra trong năm");
		buttonGroup.add(rbTKN);
		rbTKN.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbTKN.setBounds(6, 59, 316, 23);
		panel.add(rbTKN);
		
		JButton bThongKe = new JButton("Thống kê");
		bThongKe.setBounds(10, 102, 355, 31);
		getContentPane().add(bThongKe);
		bThongKe.setContentAreaFilled(false);
		bThongKe.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		
		bThongKe.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				if(rbTKS.isSelected()){
					MyReportViewer viewer=new MyReportViewer("Report/rp_Sach.jasper");
			        viewer.setVisible(true);
				}
				if(rbTKT.isSelected()){
					ReportThongKeNhapXuat viewer = new ReportThongKeNhapXuat("Report/rp_TkSachTheoThang.jasper");
					viewer.setVisible(true);
				}
				if(rbTKN.isSelected()){
					ReportThongKeSachTheoNam viewer = new ReportThongKeSachTheoNam("Report/rp_TkSachTheoNam.jasper");
					viewer.setVisible(true);
				}
			}
		});
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

