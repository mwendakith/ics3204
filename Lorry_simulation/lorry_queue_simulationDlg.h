
// lorry_queue_simulationDlg.h : header file
//

#pragma once
#include "simulation.h"


// Clorry_queue_simulationDlg dialog
class Clorry_queue_simulationDlg : public CDialogEx
{
// Construction
public:
	Clorry_queue_simulationDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_LORRY_QUEUE_SIMULATION_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedStart();
	afx_msg void OnTimer(UINT_PTR nIDEvent);

private:
	int timerID_;
	mytime::Time time_;
	int no_processing_units;
	SimilulationData sd;
	int processing_min{};
};
