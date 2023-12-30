package GUI.FrameControlBaoCao;

import javax.swing.JFrame;
import java.awt.Container;
import java.awt.Toolkit;
import net.sf.jasperreports.engine.*;
import net.sf.jasperreports.view.*;

public class ReportThongKeDoanhThu extends JFrame{
	public ReportThongKeDoanhThu(String fileName){
		super("Thống kê doanh thu");
        try {
            JasperPrint print = JasperFillManager.fillReport(fileName, null, ketnoi.ConnectDB.getConnection());
            JRViewer viewer = new JRViewer(print);

            Container c = getContentPane();
            c.add(viewer);
        } catch (Exception ex) {
            ex.printStackTrace();
        }

        setSize(600, 500);
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(null);
        setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.Login.class.getResource("/data/img/report.png")));
	}
	
	public static void main(String[] args) {
		ReportThongKeDoanhThu viewer = new ReportThongKeDoanhThu("Report/rp_TKDT.jasper");
		viewer.setVisible(true);
	}

}
