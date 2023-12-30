package GUI.FrameControlBaoCao;

import javax.swing.JFrame;
import java.awt.Container;
import java.awt.Toolkit;
import net.sf.jasperreports.engine.*;
import net.sf.jasperreports.view.*;

public class ReportTkTienLoiThang extends JFrame{
	
	public ReportTkTienLoiThang(String fileName){
		super("Thống kê tiền lời của mỗi cuốn sách trong tháng");
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
		ReportTkTienLoiThang viewer = new ReportTkTienLoiThang("Report/rp_TkTienLoiThang.jasper");
		viewer.setVisible(true);
	}

}
