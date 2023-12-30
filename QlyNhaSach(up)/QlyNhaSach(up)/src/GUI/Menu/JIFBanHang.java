package GUI.Menu;
import GUI.FrameControlBanHang.HoaDon;
import GUI.FrameControlBanHang.HuyHoaDon;
import java.awt.event.ActionEvent;
//import GUI.FrameControlThongtin.jframePhieuNhapSach;
import java.beans.PropertyVetoException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JDesktopPane;

/**
 *
 * @author 10520_000
 */
public class JIFBanHang extends javax.swing.JInternalFrame {

    private JDesktopPane desktop;
    /**
     * Creates new form JIFDanhMuc
     */
    public JIFBanHang() throws PropertyVetoException 
    {
        
        this.setFrameIcon(new ImageIcon("src/Image/login.png"));
       javax.swing.plaf.InternalFrameUI gui;  
        gui = this.getUI();
            ((javax.swing.plaf.basic.BasicInternalFrameUI)gui).setNorthPane(null);
        initComponents();

    }
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTree1 = new javax.swing.JTree();
        jPanelBanHang = new javax.swing.JPanel();
        jLabelTieuDe2 = new javax.swing.JLabel();
        jButtonHuyHoaDon = new javax.swing.JButton();
        jButtonHoaDon = new javax.swing.JButton();

        jScrollPane1.setViewportView(jTree1);

        setClosable(true);
        setIconifiable(true);
        setMaximizable(true);
        setMaximumSize(new java.awt.Dimension(80, 80));
        addComponentListener(new java.awt.event.ComponentAdapter() {
            public void componentMoved(java.awt.event.ComponentEvent evt) {
                formComponentMoved(evt);
            }
        });

        jPanelBanHang.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanelBanHang.setPreferredSize(new java.awt.Dimension(238, 127));

        jLabelTieuDe2.setBackground(new java.awt.Color(255, 153, 255));
        jLabelTieuDe2.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabelTieuDe2.setForeground(new java.awt.Color(255, 255, 255));
        jLabelTieuDe2.setText("Quản lý bán hàng");

        jButtonHuyHoaDon.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/list.png"))); // NOI18N
        jButtonHuyHoaDon.setText("Hủy hóa đơn");
        jButtonHuyHoaDon.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonHuyHoaDon.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonHuyHoaDonActionPerformed(evt);
            }
        });

        jButtonHoaDon.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/report.png"))); // NOI18N
        jButtonHoaDon.setText("Lập hóa đơn bán hàng");
        jButtonHoaDon.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonHoaDon.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonHoaDonActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanelBanHangLayout = new javax.swing.GroupLayout(jPanelBanHang);
        jPanelBanHang.setLayout(jPanelBanHangLayout);
        jPanelBanHangLayout.setHorizontalGroup(
            jPanelBanHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelBanHangLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelBanHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabelTieuDe2, javax.swing.GroupLayout.DEFAULT_SIZE, 227, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanelBanHangLayout.createSequentialGroup()
                        .addGroup(jPanelBanHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jButtonHoaDon, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonHuyHoaDon, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addContainerGap())))
        );
        jPanelBanHangLayout.setVerticalGroup(
            jPanelBanHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelBanHangLayout.createSequentialGroup()
                .addComponent(jLabelTieuDe2, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(1, 1, 1)
                .addComponent(jButtonHoaDon)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jButtonHuyHoaDon)
                .addContainerGap(41, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 261, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelBanHang, javax.swing.GroupLayout.DEFAULT_SIZE, 241, Short.MAX_VALUE)
                    .addContainerGap()))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 205, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelBanHang, javax.swing.GroupLayout.PREFERRED_SIZE, 153, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(41, Short.MAX_VALUE)))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formComponentMoved(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_formComponentMoved
        // TODO add your handling code here:
        // TODO add your handling code here:
        if(this.getLocation().y < 0){
            this.setLocation(this.getLocation().x, 0);
        }
        
        if(this.getLocation().x < 0)
        {
            this.setLocation(0, this.getLocation().y);
        }
        
    }//GEN-LAST:event_formComponentMoved

    private void jButtonHuyHoaDonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonHuyHoaDonActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
        HuyHoaDon frame;
        try {
            frame = new HuyHoaDon();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception e) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null,e);
        }
    }//GEN-LAST:event_jButtonHuyHoaDonActionPerformed

    private void jButtonHoaDonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonHoaDonActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
        HoaDon frame;
        try {
            frame = new HoaDon();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception e) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null,e);
        }
    }//GEN-LAST:event_jButtonHoaDonActionPerformed
                   
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonHoaDon;
    private javax.swing.JButton jButtonHuyHoaDon;
    private javax.swing.JLabel jLabelTieuDe2;
    private javax.swing.JPanel jPanelBanHang;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTree jTree1;
    // End of variables declaration//GEN-END:variables

    /**
     * @return the desktop
     */
    public JDesktopPane getDesktop() {
        return desktop;
    }

    /**
     * @param desktop the desktop to set
     */
    public void setDesktop(JDesktopPane desktop) {
        this.desktop = desktop;
    }
}
