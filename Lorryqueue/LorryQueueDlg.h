
// LorryQueueDlg.h : header file
//

#pragma once

#include "simulation.h"


// CLorryQueueDlg dialog
class CLorryQueueDlg : public CDialogEx
{
// Construction
public:
	CLorryQueueDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_LORRYQUEUE_DIALOG };

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
    SimilulationData sd;
    int no_processing_units{};
    int processing_min{};
    mytime::Time time_{};
};
